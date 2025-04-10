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
    public enum ControllerFamily
    {
        [Description("Gamepad")]
        Gamepad,
        [Description("Keyboard")]
        Keyboard,
        [Description("Mouse")]
        Mouse,
        [Description("Composite")]
        Composite,
        [Description("VirtualInputKeyboard")]
        VirtualInputKeyboard,
        [Description("VirtualInputMouse")]
        VirtualInputMouse,
        [Description("Unknown")]
        Unknown

    }
}
