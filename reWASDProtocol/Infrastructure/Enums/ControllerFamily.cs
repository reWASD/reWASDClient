/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<ControllerFamily>))]
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
