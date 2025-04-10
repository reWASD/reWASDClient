/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.DataTransferObjects
{
    public class NewConfigParams
    {
        public required Guid GameId { get; init; }
        public required string ConfigName { get; init; }
        public required VirtualGamepadType VirtualGamepadType { get; init; }
    }
}
