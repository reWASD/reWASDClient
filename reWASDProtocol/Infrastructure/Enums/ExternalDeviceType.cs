/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<ExternalDeviceType>))]
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

        LastIndex = ESP32S3,

        NotSelected = 1000
    }
}
