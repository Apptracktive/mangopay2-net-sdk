﻿using MangoPay.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace MangoPay.Entities
{
    /// <summary>CardPreAuthorization entity.</summary>
    public class CardPreAuthorizationDTO : EntityBase
    {
        /// <summary>The user Id of the author of the pre-authorization.</summary>
        public String AuthorId { get; set; }

        /// <summary>Represents the amount debited on the bank account 
        /// of the Author. DebitedFunds = Fees + CreditedFunds 
        /// (amount received on wallet).</summary>
        public Money DebitedFunds { get; set; }

        /// <summary>Status of the PreAuthorization.</summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PreAuthorizationStatus Status { get; set; }

        /// <summary>The status of the payment after the PreAuthorization.</summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentStatus PaymentStatus { get; set; }

        /// <summary>The PreAuthorization result code.</summary>
        public String ResultCode { get; set; }

        /// <summary>The PreAuthorization result Message explaining the result code.</summary>
        public String ResultMessage { get; set; }

        /// <summary>How the PreAuthorization has been executed..</summary>
        public PreAuthorizationExecutionType ExecutionType { get; set; }

        /// <summary>The SecureMode correspond to '3D secure' for CB Visa and MasterCard 
        /// or 'Amex Safe Key' for American Express. 
        /// This field lets you activate it manually.</summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public SecureMode SecureMode { get; set; }

        /// <summary>Identifier of the registered card (got through CardRegistration object).</summary>
        public String CardId { get; set; }

        /// <summary>The value is { true } if the SecureMode was used.</summary>
        public bool SecureModeNeeded { get; set; }

        /// <summary>This is the URL where to redirect users to proceed to 3D secure validation.</summary>
        public String SecureModeRedirectURL { get; set; }

        /// <summary>This is the URL where users are automatically redirected after 3D secure validation (if activated).</summary>
        public String SecureModeReturnURL { get; set; }

        /// <summary>The date when the payment has been processed (UNIX timestamp).</summary>
        public long ExpirationDate { get; set; }

        /// <summary>Identifier of the associated PayIn.</summary>
        public String PayInId { get; set; }
    }
}