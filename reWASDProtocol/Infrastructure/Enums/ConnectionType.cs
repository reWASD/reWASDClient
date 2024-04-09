/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectionType
    {
        Wired = 0,
        Wireless,
        Virtual,
        Integrated, // SteamDeck / Asus ROG Ally Xbox360 / Integrated Sensors (Gyro, Accel), etc
        Unknown
    }
}
