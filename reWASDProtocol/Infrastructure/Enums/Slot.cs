/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<Slot>))]
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
