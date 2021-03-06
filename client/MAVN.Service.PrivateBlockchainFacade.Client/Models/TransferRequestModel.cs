﻿using System;
using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;
using MAVN.Numerics;

namespace MAVN.Service.PrivateBlockchainFacade.Client.Models
{
    /// <summary>
    /// Transfer request details
    /// </summary>
    [PublicAPI]
    public class TransferRequestModel
    {
        /// <summary>
        /// Sender's customer id
        /// </summary>
        [Required]
        public Guid SenderCustomerId { get; set; }

        /// <summary>
        /// Recipient's customer id
        /// </summary>
        [Required]
        public Guid RecipientCustomerId { get; set; }

        /// <summary>
        /// Transfer amount
        /// </summary>
        public Money18 Amount { get; set; }

        /// <summary>
        /// The transfer request id, has to be unique
        /// </summary>
        public string TransferId { get; set; }
    }
}
