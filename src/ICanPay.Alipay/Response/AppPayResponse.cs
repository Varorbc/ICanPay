﻿using ICanPay.Alipay.Request;
using ICanPay.Core.Response;

namespace ICanPay.Alipay.Response
{
    public class AppPayResponse : IResponse
    {
        public AppPayResponse(AppPayRequest request)
        {
            OrderInfo = request.GatewayData.ToUrl();
        }

        /// <summary>
        /// 用于唤起App的订单参数
        /// </summary>
        public string OrderInfo { get; set; }
    }
}
