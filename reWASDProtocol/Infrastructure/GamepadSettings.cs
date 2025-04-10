/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Infrastructure
{
    public class GamepadSettings
    {
        public static readonly string DefaultColor = "#FFFFE795";

        public required string ID { get; init; }
        public string DisplayName { get; set; } = "";
        public ControllerType ControllerType { get; init; }
        public string Color { get; set; } = DefaultColor;
        public bool ShowBatteryInTaskbar { get; set; } = true;
    }
}
