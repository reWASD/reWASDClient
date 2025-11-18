/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<BatteryChargingState>))]
    public enum BatteryChargingState
    {
        Inactive = 0,
        Active,
        Error,
        Unknown
    }
}
