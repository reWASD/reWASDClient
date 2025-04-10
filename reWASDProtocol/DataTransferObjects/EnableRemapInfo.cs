/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure;

namespace reWASDProtocol.DataTransferObjects
{
    public class EnableRemapInfo
    {
        public Guid? Guid { get; init; }
        public bool RemapNoToggled { get; init; }
        public required EnableRemapBundle? Bundle { get; set; }
    }
}
