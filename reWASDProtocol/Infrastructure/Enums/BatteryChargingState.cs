/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BatteryChargingState
    {
        Inactive = 0,
        Active,
        Error,
        Unknown
    }
}
