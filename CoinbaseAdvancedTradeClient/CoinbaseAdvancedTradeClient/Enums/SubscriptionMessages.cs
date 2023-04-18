﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace CoinbaseAdvancedTradeClient.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionMessages
    {
        [EnumMember(Value = "subscribe")]
        Subscribe,

        [EnumMember(Value = "unsubscribe")]
        Unsubscribe
    }
}
