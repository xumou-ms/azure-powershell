﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Rest;

namespace Microsoft.Azure.Commands.ContainerRegistry.Track2Models
{
    internal class DataServiceCredential
    {
        private readonly IAuthenticationFactory _authenticationFactory;
        private readonly IAzureContext _context;
        private readonly string _endpointName;

        public DataServiceCredential(IAuthenticationFactory authFactory, IAzureContext context, string resourceIdEndpoint)
        {
            if (authFactory == null)
                throw new ArgumentNullException("authFactory");
            if (context == null)
                throw new ArgumentNullException("context");
            _authenticationFactory = authFactory;
            _context = context;
            _endpointName = resourceIdEndpoint;
            this.TenantId = GetTenantId(context);
        }

        public string TenantId { get; private set; }

        /// <summary>
        /// Authentication callback method required by KeyVaultClient
        /// </summary>
        /// <param name="authority"></param>
        /// <param name="resource"></param>
        /// <param name="scope"></param>
        /// <returns></returns>
        public Task<string> OnAuthentication(string authority, string resource, string scope)
        {
            // TODO: Add trace to log tokenType, resource, authority, scope etc
            string tokenStr = string.Empty;

            // overriding the cached resourceId value to resource returned from the server
            if (!string.IsNullOrEmpty(resource))
            {
                _context.Environment.SetEndpoint(_endpointName, resource);
            }

            var bundle = GetTokenInternal(this.TenantId, this._authenticationFactory, this._context, this._endpointName);
            bundle.Item1.AuthorizeRequest((tokenType, tokenValue) =>
            {
                tokenStr = tokenValue;
            });
            return Task.FromResult<string>(tokenStr);
        }

        public string GetToken()
        {
            return GetAccessToken().AccessToken;
        }

        public IAccessToken GetAccessToken()
        {
            return GetTokenInternal(TenantId, _authenticationFactory, _context, _endpointName).Item1;
        }

        private static string GetTenantId(IAzureContext context)
        {
            if (context.Account == null)
            {
                throw new ArgumentException("No account found in the context. Please login using Connect-AzAccount.");
            }

            var tenantId = string.Empty;
            if (context.Tenant != null && context.Tenant.GetId() != Guid.Empty)
            {
                tenantId = context.Tenant.Id.ToString();
            }
            else if (string.IsNullOrWhiteSpace(tenantId) && context.Subscription != null && context.Account != null)
            {
                tenantId = context.Subscription.GetPropertyAsArray(AzureSubscription.Property.Tenants)
                       .Intersect(context.Account.GetPropertyAsArray(AzureAccount.Property.Tenants))
                       .FirstOrDefault();
            }

            return tenantId;
        }

        private static Tuple<IAccessToken, string> GetTokenInternal(string tenantId, IAuthenticationFactory authFactory, IAzureContext context, string resourceIdEndpoint)
        {
            if (string.IsNullOrWhiteSpace(tenantId))
                throw new ArgumentException("No tenant found in the context.  Please ensure that the credentials you provided are authorized to access an Azure subscription, then run Connect-AzAccount to login.");

            try
            {
                var tokenCache = AzureSession.Instance.TokenCache;
                if (context.TokenCache != null && context.TokenCache.CacheData != null && context.TokenCache.CacheData.Length > 0)
                {
                    tokenCache = context.TokenCache;
                }

                var accesstoken = authFactory.Authenticate(context.Account, context.Environment, tenantId, null, ShowDialog.Never,
                    null, tokenCache, resourceIdEndpoint);

                if (context.TokenCache != null && context.TokenCache.CacheData != null && context.TokenCache.CacheData.Length > 0)
                {
                    context.TokenCache = tokenCache;
                }

                return Tuple.Create(accesstoken, context.Environment.GetEndpoint(resourceIdEndpoint));
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Your Azure credentials have not been set up or have expired, please run Connect-AzAccount to set up your Azure credentials.", ex);
            }
        }
    }
}
