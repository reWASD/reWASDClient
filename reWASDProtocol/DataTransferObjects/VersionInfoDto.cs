/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.DataTransferObjects
{
    public readonly struct VersionInfoDto
    {
        public ushort Major { get; init; }
        public ushort Minor { get; init; }
        public ushort Build { get; init; }
        public ushort Revision { get; init; }
    }
}
