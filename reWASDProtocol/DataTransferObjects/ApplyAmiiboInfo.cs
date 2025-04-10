/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.DataTransferObjects
{
    public class ApplyAmiiboInfo
    {
        public Guid ControllerGuid {get; init; }
        public required string Path { get; init; }
        public Slot Slot { get; init; }
        public required byte[] AmiiboData { get; init; }
    }

}
