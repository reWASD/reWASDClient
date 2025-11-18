/*
 *    Http protocol data structure.
 *
 *    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
 */

namespace reWASDProtocol.Infrastructure
{
    public readonly struct ManufacturerInfo
    {
        public string Description { get; init; }
        public string ContainerDescription { get; init; }
        public string Name { get; init; }
        public string ProductName { get; init; }
        public ushort VendorId { get; init; }
        public ushort ProductId { get; init; }
    }
}
