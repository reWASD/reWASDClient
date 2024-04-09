/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.DataTransferObjects
{
    public class NewGameParams
    {
        public required string Name { get; init; }
        public required string ImageSourcePath { get; init; }
        public required List<string> ApplicationNames { get; init; }
        public required bool CreateDefaultConfig { get; init; }
        public required VirtualGamepadType VirtualGamepadType { get; init; }
    }
}
