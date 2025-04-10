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
