/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/


using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<BatteryLevel>))]
    public enum BatteryLevel
    {
        Critical = 0,
        Low,
        Medium,
        High,
        Unknown
    }
}
