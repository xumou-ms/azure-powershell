﻿﻿// ----------------------------------------------------------------------------------
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

namespace Microsoft.WindowsAzure.Commands.Storage.Model.Contract
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.File;

    /// <summary>
    /// File management interface
    /// </summary>
    public interface IStorageFileManagement : IStorageManagement
    {
        /// <summary>
        ///  Returns a reference to a Microsoft.WindowsAzure.Storage.File.CloudFileShare
        ///  object with the specified name.
        /// </summary>
        /// <param name="shareName">A string containing the name of the share.</param>
        /// <returns>A reference to a share.</returns>
        CloudFileShare GetShareReference(string shareName);

        /// <summary>
        ///  Enumerates the files and directories under a certain folder.
        /// </summary>
        /// <param name="directory">Indicating the directory to be listed.</param>
        /// <param name="enumerationAction">Indicating the action for enumerated items.</param>
        /// <param name="options">
        ///  An Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        /// </param>
        /// <param name="token">Indicating the cancellation token.</param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task EnumerateFilesAndDirectoriesAsync(CloudFileDirectory directory, Action<IListFileItem> enumerationAction, FileRequestOptions options, OperationContext operationContext, CancellationToken token);

        /// <summary>
        ///  Returns a task that performs an asynchronous operation to retrieve the share's
        ///  attributes.
        /// </summary>
        /// <param name="share">Indicating the share.</param>
        /// <param name="accessCondition">
        ///  An Microsoft.WindowsAzure.Storage.AccessCondition object that represents
        ///  the access conditions for the share. If null, no condition is used.
        /// </param>
        /// <param name="options">
        ///  A Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        ///  </param>
        /// <param name="token">
        ///  A System.Threading.CancellationToken to observe while waiting for a task
        ///  to complete.
        /// </param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task FetchShareAttributesAsync(CloudFileShare share, AccessCondition accessCondition, FileRequestOptions options, OperationContext operationContext, CancellationToken token);

        /// <summary>
        /// Enumerates the shares for a given prefix.
        /// </summary>
        /// <param name="prefix">Indicating the prefix.</param>
        /// <param name="listingDetails">
        /// A value that indicates whether to return share metadata with the listing.
        /// </param>
        /// <param name="enumerationAction">Indicating the action for enumerated items.</param>
        /// <param name="options">
        ///  An Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        /// </param>
        /// <param name="token">Indicating the cancellation token.</param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task EnumerateSharesAsync(string prefix, ShareListingDetails detailsIncluded, Action<CloudFileShare> enumerationAction, FileRequestOptions options, OperationContext operationContext, CancellationToken token);

        /// <summary>
        /// Returns a task that performs an asynchronous operation to create a directory.
        /// </summary>
        /// <param name="directory">
        /// Indicating the reference of the directory to be created.
        /// </param>
        /// <param name="options">
        ///  A Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        ///  </param>
        /// <param name="cancellationToken">
        ///  A System.Threading.CancellationToken to observe while waiting for a task
        ///  to complete.
        /// </param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task CreateDirectoryAsync(CloudFileDirectory directory, FileRequestOptions options, OperationContext operationContext, CancellationToken cancellationToken);

        /// <summary>
        /// Returns a task that performs an asynchronous operation to determine whether a
        /// directory exists.
        /// </summary>
        /// <param name="directory">
        /// Indicating the reference of the directory.
        /// </param>
        /// <param name="options">
        ///  A Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        ///  </param>
        /// <param name="cancellationToken">
        ///  A System.Threading.CancellationToken to observe while waiting for a task
        ///  to complete.
        /// </param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task<bool> DirectoryExistsAsync(CloudFileDirectory directory, FileRequestOptions options, OperationContext operationContext, CancellationToken cancellationToken);

        /// <summary>
        /// Returns a task that performs an asynchronous operation to determine whether a
        /// file exists.
        /// </summary>
        /// <param name="file">
        /// Indicating the reference of the file.
        /// </param>
        /// <param name="options">
        ///  A Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        ///  </param>
        /// <param name="cancellationToken">
        ///  A System.Threading.CancellationToken to observe while waiting for a task
        ///  to complete.
        /// </param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task<bool> FileExistsAsync(CloudFile file, FileRequestOptions options, OperationContext operationContext, CancellationToken cancellationToken);

        /// <summary>
        /// Returns a task that performs an asynchronous operation to create a share.
        /// </summary>
        /// <param name="share">
        /// Indicating the reference of the share to be created.
        /// </param>
        /// <param name="options">
        ///  A Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        ///  </param>
        /// <param name="cancellationToken">
        ///  A System.Threading.CancellationToken to observe while waiting for a task
        ///  to complete.
        /// </param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task CreateShareAsync(CloudFileShare share, FileRequestOptions options, OperationContext operationContext, CancellationToken cancellationToken);

        /// <summary>
        /// Returns a task that performs an asynchronous operation to delete a directory.
        /// </summary>
        /// <param name="directory">
        /// Indicating the reference of the directory to be deleted.
        /// </param>
        /// <param name="accessCondition">
        ///  An Microsoft.WindowsAzure.Storage.AccessCondition object that represents
        ///  the access conditions for the share. If null, no condition is used.
        /// </param>
        /// <param name="options">
        ///  A Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        ///  </param>
        /// <param name="cancellationToken">
        ///  A System.Threading.CancellationToken to observe while waiting for a task
        ///  to complete.
        /// </param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task DeleteDirectoryAsync(CloudFileDirectory directory, AccessCondition accessCondition, FileRequestOptions options, OperationContext operationContext, CancellationToken cancellationToken);

        /// <summary>
        /// Returns a task that performs an asynchronous operation to delete a share.
        /// </summary>
        /// <param name="share">
        /// Indicating the reference of the share to be deleted.
        /// </param>
        /// <param name="accessCondition">
        ///  An Microsoft.WindowsAzure.Storage.AccessCondition object that represents
        ///  the access conditions for the share. If null, no condition is used.
        /// </param>
        /// <param name="options">
        ///  A Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        ///  </param>
        /// <param name="cancellationToken">
        ///  A System.Threading.CancellationToken to observe while waiting for a task
        ///  to complete.
        /// </param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task DeleteShareAsync(CloudFileShare share, AccessCondition accessCondition, FileRequestOptions options, OperationContext operationContext, CancellationToken cancellationToken);

        /// <summary>
        /// Returns a task that performs an asynchronous operation to delete a file.
        /// </summary>
        /// <param name="file">
        /// Indicating the reference of the file to be deleted.
        /// </param>
        /// <param name="accessCondition">
        ///  An Microsoft.WindowsAzure.Storage.AccessCondition object that represents
        ///  the access conditions for the share. If null, no condition is used.
        /// </param>
        /// <param name="options">
        ///  A Microsoft.WindowsAzure.Storage.File.FileRequestOptions object that specifies
        ///  additional options for the request.
        /// </param>
        /// <param name="operationContext">
        ///  An Microsoft.WindowsAzure.Storage.OperationContext object that represents
        ///  the context for the current operation.
        ///  </param>
        /// <param name="cancellationToken">
        ///  A System.Threading.CancellationToken to observe while waiting for a task
        ///  to complete.
        /// </param>
        /// <returns>
        ///  A System.Threading.Tasks.Task object that represents the current operation.
        /// </returns>
        Task DeleteFileAsync(CloudFile file, AccessCondition accessCondition, FileRequestOptions options, OperationContext operationContext, CancellationToken cancellationToken);
    }
}
