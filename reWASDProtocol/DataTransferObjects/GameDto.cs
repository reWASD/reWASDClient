/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.DataTransferObjects
{
    public class GameDto
    {
        public required Guid Id { get; init; }
        public required string Name { get; init; }
        public required List<ConfigDto> ConfigCollection { get; init; }
    }
}
