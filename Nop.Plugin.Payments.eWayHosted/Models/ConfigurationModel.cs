﻿using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.Payments.eWayHosted.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        [NopResourceDisplayName("Plugins.Payments.eWayHosted.CustomerId")]
        public string CustomerId { get; set; }

        [NopResourceDisplayName("Plugins.Payments.eWayHosted.Username")]
        public string Username { get; set; }

        [NopResourceDisplayName("Plugins.Payments.eWayHosted.PaymentPage")]
        public string PaymentPage { get; set; }

        [NopResourceDisplayName("Plugins.Payments.eWayHosted.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
    }
}