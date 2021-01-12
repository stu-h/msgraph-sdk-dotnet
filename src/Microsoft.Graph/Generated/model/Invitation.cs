// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Invitation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Invitation : Entity
    {
    
		///<summary>
		/// The Invitation constructor
		///</summary>
        public Invitation()
        {
            this.ODataType = "microsoft.graph.invitation";
        }
	
        /// <summary>
        /// Gets or sets invited user display name.
        /// The display name of the user being invited.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invitedUserDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string InvitedUserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets invited user email address.
        /// The email address of the user being invited. Required. The following special characters are not permitted in the email address:Tilde (~)Exclamation point (!)Number sign (#)Dollar sign ($)Percent (%)Circumflex (^)Ampersand (&amp;)Asterisk (*)Parentheses (( ))Plus sign (+)Equal sign (=)Brackets ([ ])Braces ({ })Backslash (/)Slash mark (/)Pipe (/|)Semicolon (;)Colon (:)Quotation marks (')Angle brackets (&amp;lt; &amp;gt;)Question mark (?)Comma (,)However, the following exceptions apply:A period (.) or a hyphen (-) is permitted anywhere in the user name, except at the beginning or end of the name.An underscore (_) is permitted anywhere in the user name. This includes at the beginning or end of the name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invitedUserEmailAddress", Required = Newtonsoft.Json.Required.Default)]
        public string InvitedUserEmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets invited user message info.
        /// Additional configuration for the message being sent to the invited user, including customizing message text, language and cc recipient list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invitedUserMessageInfo", Required = Newtonsoft.Json.Required.Default)]
        public InvitedUserMessageInfo InvitedUserMessageInfo { get; set; }
    
        /// <summary>
        /// Gets or sets invited user type.
        /// The userType of the user being invited. By default, this is Guest. You can invite as Member if you are a company administrator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invitedUserType", Required = Newtonsoft.Json.Required.Default)]
        public string InvitedUserType { get; set; }
    
        /// <summary>
        /// Gets or sets invite redeem url.
        /// The URL the user can use to redeem their invitation. Read-only
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inviteRedeemUrl", Required = Newtonsoft.Json.Required.Default)]
        public string InviteRedeemUrl { get; set; }
    
        /// <summary>
        /// Gets or sets invite redirect url.
        /// The URL the user should be redirected to once the invitation is redeemed. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inviteRedirectUrl", Required = Newtonsoft.Json.Required.Default)]
        public string InviteRedirectUrl { get; set; }
    
        /// <summary>
        /// Gets or sets send invitation message.
        /// Indicates whether an email should be sent to the user being invited or not. The default is false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sendInvitationMessage", Required = Newtonsoft.Json.Required.Default)]
        public bool? SendInvitationMessage { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the invitation. Possible values: PendingAcceptance, Completed, InProgress, and Error
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets invited user.
        /// The user created as part of the invitation creation. Read-Only
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invitedUser", Required = Newtonsoft.Json.Required.Default)]
        public User InvitedUser { get; set; }
    
    }
}

