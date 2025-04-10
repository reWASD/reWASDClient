/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.DataTransferObjects
{
    public class SpecialProfileInfo
    {
        public ExternalDeviceType ExternalDeviceType { get; init; }
        public VirtualGamepadType VirtualGamepadType { get; init; }
        public required string ComPort { get; init; }
        public required uint BaudRate { get; init; }
    }
}
