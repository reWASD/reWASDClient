/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<PeripheralPhysicalType>))]
    public enum PeripheralPhysicalType
    {
        Unknown,
        Keyboard,
        Mouse
    }
}
