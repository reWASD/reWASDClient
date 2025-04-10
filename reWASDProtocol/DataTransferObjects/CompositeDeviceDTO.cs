/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.DataTransferObjects
{
    public class CompositeDeviceDto
    {
        public required List<Guid?> Guids { get; init; }
    }
}
