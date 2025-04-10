/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.DataTransferObjects
{
    public class BlockListGamepadDto
    {
        public required List<ulong> Ids { get; init; }
        public required string Label { get; init; }
        public required string DisplayName { get; init; }
        public required ControllerFamily ControllerFamily { get; init; }
        public required List<ControllerType> ControllerTypeEnums { get; init; }
    }
}
