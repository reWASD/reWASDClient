/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/


using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<ConnectionType>))]
    public enum ConnectionType
    {
        Wired = 0,
        Wireless,
        Virtual,
        Integrated, // SteamDeck / Asus ROG Ally Xbox360 / Integrated Sensors (Gyro, Accel), etc
        Unknown
    }
}
