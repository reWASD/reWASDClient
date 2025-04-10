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
    public enum BatteryLevel
    {
        Critical = 0,
        Low,
        Medium,
        High,
        Unknown
    }
}
