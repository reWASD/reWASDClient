/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.DataTransferObjects
{
    public class RenameGameParams
    {
        public required Guid Id { get; init; }
        public required string NewName { get; init; }
    }
}
