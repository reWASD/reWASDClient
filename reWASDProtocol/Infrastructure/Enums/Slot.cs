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
    public enum Slot
    {
        [Description("Slot 1")]
        Slot1,
        [Description("Slot 2")]
        Slot2,
        [Description("Slot 3")]
        Slot3,
        [Description("Slot 4")]
        Slot4
    }
}
