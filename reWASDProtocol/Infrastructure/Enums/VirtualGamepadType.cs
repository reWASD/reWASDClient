/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<VirtualGamepadType>))]
    public enum VirtualGamepadType
    {
        [Description("Virtual Xbox 360")] 
        Xbox360,
        [Description("Virtual Xbox One")]
        XboxOneBT,
        [Description("Virtual DualShock 4")] 
        SonyDualshock4,
        [Description("Virtual DualShock 3")]
        SonyDualshock3,
        [Description("Virtual Nintendo Switch Pro")] 
        NintendoSwitchPro,
    }
}
