/*
 *    Http protocol data structure.
 *
 *    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
 */

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.DataTransferObjects
{
    public class SelectSlotInfo
    {
        public Guid Guid { get; init; }
        public Slot Slot { get; init; }
    }

    public class ClearSlotInfo
    {
        public Guid? Guid { get; init; }
        public required List<Slot> Slots { get; init; }
    }
}
