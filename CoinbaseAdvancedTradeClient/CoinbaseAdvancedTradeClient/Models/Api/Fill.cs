﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinbaseAdvancedTradeClient.Models.Api
{
    public class Fill
    {
        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("trade_id")]
        public string TradeId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("trade_time")]
        public DateTime? TradeTime { get; set; }

        [JsonProperty("trade_type")]
        public string TradeType { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("commission")]
        public string Commission { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("sequence_timestamp")]
        public DateTime? SequenceTimestamp { get; set; }

        [JsonProperty("liquidity_indicator")]
        public string LiquidityIndicator { get; set; }

        [JsonProperty("size_in_quote")]
        public bool SizeInQuote { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }
    }
}
