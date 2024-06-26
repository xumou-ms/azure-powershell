// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Disk input for update.
    /// </summary>
    public partial class UpdateDiskInput
    {
        /// <summary>
        /// Initializes a new instance of the UpdateDiskInput class.
        /// </summary>
        public UpdateDiskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateDiskInput class.
        /// </summary>

        /// <param name="diskId">The disk Id.
        /// </param>

        /// <param name="targetDiskName">The target disk name.
        /// </param>
        public UpdateDiskInput(string diskId, string targetDiskName = default(string))

        {
            this.DiskId = diskId;
            this.TargetDiskName = targetDiskName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the disk Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskId")]
        public string DiskId {get; set; }

        /// <summary>
        /// Gets or sets the target disk name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetDiskName")]
        public string TargetDiskName {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.DiskId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DiskId");
            }


        }
    }
}