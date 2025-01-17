// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Schedule info of the role eligibility schedule. </summary>
    public partial class RoleEligibilityScheduleRequestPropertiesScheduleInfo
    {
        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestPropertiesScheduleInfo. </summary>
        public RoleEligibilityScheduleRequestPropertiesScheduleInfo()
        {
        }

        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestPropertiesScheduleInfo. </summary>
        /// <param name="startOn"> Start DateTime of the role eligibility schedule. </param>
        /// <param name="expiration"> Expiration of the role eligibility schedule. </param>
        internal RoleEligibilityScheduleRequestPropertiesScheduleInfo(DateTimeOffset? startOn, RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration expiration)
        {
            StartOn = startOn;
            Expiration = expiration;
        }

        /// <summary> Start DateTime of the role eligibility schedule. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Expiration of the role eligibility schedule. </summary>
        public RoleEligibilityScheduleRequestPropertiesScheduleInfoExpiration Expiration { get; set; }
    }
}
