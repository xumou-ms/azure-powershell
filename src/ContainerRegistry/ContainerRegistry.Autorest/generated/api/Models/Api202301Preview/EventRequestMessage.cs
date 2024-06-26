// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The event request message sent to the service URI.</summary>
    public partial class EventRequestMessage :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessage,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageInternal
    {

        /// <summary>
        /// The subject or username associated with the request context that generated the event.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string ActorName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).ActorName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).ActorName = value ?? null; }

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContent _content;

        /// <summary>The content of the event request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContent Content { get => (this._content = this._content ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.EventContent()); set => this._content = value; }

        /// <summary>The action that encompasses the provided event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string ContentAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Action = value ?? null; }

        /// <summary>The event ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string ContentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Id = value ?? null; }

        /// <summary>The time at which the event occurred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public global::System.DateTime? ContentTimestamp { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Timestamp; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Timestamp = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Header" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageHeaders _header;

        /// <summary>The headers of the event request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageHeaders Header { get => (this._header = this._header ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.EventRequestMessageHeaders()); set => this._header = value; }

        /// <summary>Backing field for <see cref="Method" /> property.</summary>
        private string _method;

        /// <summary>The HTTP method used to send the event request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Method { get => this._method; set => this._method = value; }

        /// <summary>Internal Acessors for Content</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContent Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageInternal.Content { get => (this._content = this._content ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.EventContent()); set { {_content = value;} } }

        /// <summary>Internal Acessors for ContentActor</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IActor Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageInternal.ContentActor { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Actor; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Actor = value; }

        /// <summary>Internal Acessors for ContentRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IRequest Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageInternal.ContentRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Request; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Request = value; }

        /// <summary>Internal Acessors for ContentSource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ISource Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageInternal.ContentSource { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Source; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Source = value; }

        /// <summary>Internal Acessors for ContentTarget</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITarget Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageInternal.ContentTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).Target = value; }

        /// <summary>
        /// The IP or hostname and possibly port of the client connection that initiated the event. This is the RemoteAddr from the
        /// standard http request.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string RequestAddr { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestAddr; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestAddr = value ?? null; }

        /// <summary>
        /// The externally accessible hostname of the registry instance, as specified by the http host header on incoming requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string RequestHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestHost; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestHost = value ?? null; }

        /// <summary>The ID of the request that initiated the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string RequestId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestId = value ?? null; }

        /// <summary>The request method that generated the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string RequestMethod { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestMethod; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestMethod = value ?? null; }

        /// <summary>Backing field for <see cref="RequestUri" /> property.</summary>
        private string _requestUri;

        /// <summary>The URI used to send the event request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string RequestUri { get => this._requestUri; set => this._requestUri = value; }

        /// <summary>The user agent header of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string RequestUseragent { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestUseragent; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).RequestUseragent = value ?? null; }

        /// <summary>
        /// The IP or hostname and the port of the registry node that generated the event. Generally, this will be resolved by os.Hostname()
        /// along with the running port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string SourceAddr { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).SourceAddr; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).SourceAddr = value ?? null; }

        /// <summary>The running instance of an application. Changes after each restart.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string SourceInstanceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).SourceInstanceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).SourceInstanceId = value ?? null; }

        /// <summary>
        /// The digest of the content, as defined by the Registry V2 HTTP API Specification.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetDigest { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetDigest; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetDigest = value ?? null; }

        /// <summary>The number of bytes of the content. Same as Size field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public long? TargetLength { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetLength; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetLength = value ?? default(long); }

        /// <summary>The MIME type of the referenced object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetMediaType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetMediaType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetMediaType = value ?? null; }

        /// <summary>The name of the artifact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetName = value ?? null; }

        /// <summary>The repository name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetRepository { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetRepository; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetRepository = value ?? null; }

        /// <summary>The number of bytes of the content. Same as Length field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public long? TargetSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetSize = value ?? default(long); }

        /// <summary>The tag name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetTag = value ?? null; }

        /// <summary>The direct URL to the content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetUrl = value ?? null; }

        /// <summary>The version of the artifact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string TargetVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContentInternal)Content).TargetVersion = value ?? null; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The HTTP message version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="EventRequestMessage" /> instance.</summary>
        public EventRequestMessage()
        {

        }
    }
    /// The event request message sent to the service URI.
    public partial interface IEventRequestMessage :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The subject or username associated with the request context that generated the event.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subject or username associated with the request context that generated the event.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ActorName { get; set; }
        /// <summary>The action that encompasses the provided event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The action that encompasses the provided event.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        string ContentAction { get; set; }
        /// <summary>The event ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The event ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ContentId { get; set; }
        /// <summary>The time at which the event occurred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time at which the event occurred.",
        SerializedName = @"timestamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ContentTimestamp { get; set; }
        /// <summary>The headers of the event request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The headers of the event request message.",
        SerializedName = @"headers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageHeaders) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageHeaders Header { get; set; }
        /// <summary>The HTTP method used to send the event request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The HTTP method used to send the event request message.",
        SerializedName = @"method",
        PossibleTypes = new [] { typeof(string) })]
        string Method { get; set; }
        /// <summary>
        /// The IP or hostname and possibly port of the client connection that initiated the event. This is the RemoteAddr from the
        /// standard http request.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP or hostname and possibly port of the client connection that initiated the event. This is the RemoteAddr from the standard http request.",
        SerializedName = @"addr",
        PossibleTypes = new [] { typeof(string) })]
        string RequestAddr { get; set; }
        /// <summary>
        /// The externally accessible hostname of the registry instance, as specified by the http host header on incoming requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The externally accessible hostname of the registry instance, as specified by the http host header on incoming requests.",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string RequestHost { get; set; }
        /// <summary>The ID of the request that initiated the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the request that initiated the event.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string RequestId { get; set; }
        /// <summary>The request method that generated the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request method that generated the event.",
        SerializedName = @"method",
        PossibleTypes = new [] { typeof(string) })]
        string RequestMethod { get; set; }
        /// <summary>The URI used to send the event request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI used to send the event request message.",
        SerializedName = @"requestUri",
        PossibleTypes = new [] { typeof(string) })]
        string RequestUri { get; set; }
        /// <summary>The user agent header of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user agent header of the request.",
        SerializedName = @"useragent",
        PossibleTypes = new [] { typeof(string) })]
        string RequestUseragent { get; set; }
        /// <summary>
        /// The IP or hostname and the port of the registry node that generated the event. Generally, this will be resolved by os.Hostname()
        /// along with the running port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP or hostname and the port of the registry node that generated the event. Generally, this will be resolved by os.Hostname() along with the running port.",
        SerializedName = @"addr",
        PossibleTypes = new [] { typeof(string) })]
        string SourceAddr { get; set; }
        /// <summary>The running instance of an application. Changes after each restart.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The running instance of an application. Changes after each restart.",
        SerializedName = @"instanceID",
        PossibleTypes = new [] { typeof(string) })]
        string SourceInstanceId { get; set; }
        /// <summary>
        /// The digest of the content, as defined by the Registry V2 HTTP API Specification.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The digest of the content, as defined by the Registry V2 HTTP API Specification.",
        SerializedName = @"digest",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDigest { get; set; }
        /// <summary>The number of bytes of the content. Same as Size field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of bytes of the content. Same as Size field.",
        SerializedName = @"length",
        PossibleTypes = new [] { typeof(long) })]
        long? TargetLength { get; set; }
        /// <summary>The MIME type of the referenced object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The MIME type of the referenced object.",
        SerializedName = @"mediaType",
        PossibleTypes = new [] { typeof(string) })]
        string TargetMediaType { get; set; }
        /// <summary>The name of the artifact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the artifact.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TargetName { get; set; }
        /// <summary>The repository name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The repository name.",
        SerializedName = @"repository",
        PossibleTypes = new [] { typeof(string) })]
        string TargetRepository { get; set; }
        /// <summary>The number of bytes of the content. Same as Length field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of bytes of the content. Same as Length field.",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(long) })]
        long? TargetSize { get; set; }
        /// <summary>The tag name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tag name.",
        SerializedName = @"tag",
        PossibleTypes = new [] { typeof(string) })]
        string TargetTag { get; set; }
        /// <summary>The direct URL to the content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The direct URL to the content.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string TargetUrl { get; set; }
        /// <summary>The version of the artifact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the artifact.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVersion { get; set; }
        /// <summary>The HTTP message version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The HTTP message version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// The event request message sent to the service URI.
    internal partial interface IEventRequestMessageInternal

    {
        /// <summary>
        /// The subject or username associated with the request context that generated the event.
        /// </summary>
        string ActorName { get; set; }
        /// <summary>The content of the event request message.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventContent Content { get; set; }
        /// <summary>The action that encompasses the provided event.</summary>
        string ContentAction { get; set; }
        /// <summary>
        /// The agent that initiated the event. For most situations, this could be from the authorization context of the request.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IActor ContentActor { get; set; }
        /// <summary>The event ID.</summary>
        string ContentId { get; set; }
        /// <summary>The request that generated the event.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IRequest ContentRequest { get; set; }
        /// <summary>
        /// The registry node that generated the event. Put differently, while the actor initiates the event, the source generates
        /// it.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ISource ContentSource { get; set; }
        /// <summary>The target of the event.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITarget ContentTarget { get; set; }
        /// <summary>The time at which the event occurred.</summary>
        global::System.DateTime? ContentTimestamp { get; set; }
        /// <summary>The headers of the event request message.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IEventRequestMessageHeaders Header { get; set; }
        /// <summary>The HTTP method used to send the event request message.</summary>
        string Method { get; set; }
        /// <summary>
        /// The IP or hostname and possibly port of the client connection that initiated the event. This is the RemoteAddr from the
        /// standard http request.
        /// </summary>
        string RequestAddr { get; set; }
        /// <summary>
        /// The externally accessible hostname of the registry instance, as specified by the http host header on incoming requests.
        /// </summary>
        string RequestHost { get; set; }
        /// <summary>The ID of the request that initiated the event.</summary>
        string RequestId { get; set; }
        /// <summary>The request method that generated the event.</summary>
        string RequestMethod { get; set; }
        /// <summary>The URI used to send the event request message.</summary>
        string RequestUri { get; set; }
        /// <summary>The user agent header of the request.</summary>
        string RequestUseragent { get; set; }
        /// <summary>
        /// The IP or hostname and the port of the registry node that generated the event. Generally, this will be resolved by os.Hostname()
        /// along with the running port.
        /// </summary>
        string SourceAddr { get; set; }
        /// <summary>The running instance of an application. Changes after each restart.</summary>
        string SourceInstanceId { get; set; }
        /// <summary>
        /// The digest of the content, as defined by the Registry V2 HTTP API Specification.
        /// </summary>
        string TargetDigest { get; set; }
        /// <summary>The number of bytes of the content. Same as Size field.</summary>
        long? TargetLength { get; set; }
        /// <summary>The MIME type of the referenced object.</summary>
        string TargetMediaType { get; set; }
        /// <summary>The name of the artifact.</summary>
        string TargetName { get; set; }
        /// <summary>The repository name.</summary>
        string TargetRepository { get; set; }
        /// <summary>The number of bytes of the content. Same as Length field.</summary>
        long? TargetSize { get; set; }
        /// <summary>The tag name.</summary>
        string TargetTag { get; set; }
        /// <summary>The direct URL to the content.</summary>
        string TargetUrl { get; set; }
        /// <summary>The version of the artifact.</summary>
        string TargetVersion { get; set; }
        /// <summary>The HTTP message version.</summary>
        string Version { get; set; }

    }
}