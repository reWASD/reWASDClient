/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.DataTransferObjects
{
    public class ImportConfigInfo
    {
        public required Guid GameId { get; init; }
        public required string Name { get; init; }
        public required string Content { get; init; }
        public required bool IsCloning { get; init; }
        public required bool RewriteExisting { get; init; }
    }
}
