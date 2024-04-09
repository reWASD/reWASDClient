/*
 *    Http protocol data structure.
 *
 *    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
 */

namespace reWASDProtocol.DataTransferObjects
{
    public class AppliedConfigDto
    {
        public required Guid Id { get; init; }
        public required Guid GameId { get; init; }
        public required string Name { get; init; }
        public required string GameName { get; init; }
    }
}
