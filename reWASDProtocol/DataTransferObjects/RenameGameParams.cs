﻿/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.DataTransferObjects
{
    public class RenameGameParams
    {
        public required Guid Id { get; init; }
        public required string NewName { get; init; }
    }
}
