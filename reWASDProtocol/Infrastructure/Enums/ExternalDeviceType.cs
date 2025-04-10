/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using Newtonsoft.Json.Converters;
using System.ComponentModel;
using Newtonsoft.Json;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExternalDeviceType
    {
        [Description("Bluetooth")]
        Bluetooth,
        [Description("GIMX")]
        GIMX,
        [Description("ESP32")]
        ESP32,
        [Description("ESP32-S2")]
        ESP32S2,
        [Description("ESP32-S3")]
        ESP32S3,

        NotSelected = 1000
    }
}
