﻿using CoinbaseAdvancedTradeClient.Models.Api.Products;
using Newtonsoft.Json;

namespace CoinbaseAdvancedTradeClient.Models.Pages
{
    public class CandlesPage : Page
    {
        [JsonProperty("candles")]
        public List<Candle> Candles { get; set; }
    }
}
