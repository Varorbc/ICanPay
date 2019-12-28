﻿using System.ComponentModel.DataAnnotations;
using PaySharp.Allinpay.Enum;
using PaySharp.Core;

namespace PaySharp.Allinpay.Domain
{
    public class UnifiedPayModel : BasePayModel
    {
        /// <summary>
        /// 支付方式
        /// </summary>
        public PayType PayType { get; set; }

        /// <summary>
        /// 订单有效时间，以分为单位
        /// </summary>
        public int ValidTime { get; set; } = 5;

        /// <summary>
        /// 支付平台用户标识
        /// </summary>
        [ReName(Name = "acct")]
        [StringLength(32, ErrorMessage = "支付平台用户标识最大长度为32位")]
        public string UserId { get; set; }

        /// <summary>
        /// 商户的终端ip
        /// </summary>
        [ReName(Name = "cusip")]
        [StringLength(16, ErrorMessage = "商户的终端ip最大长度为16位")]
        public string TerminalIP { get; set; }
    }
}
