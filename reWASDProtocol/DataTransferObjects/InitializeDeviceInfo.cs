/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.DataTransferObjects
{
    public class InitializeDeviceInfo
    {
        public Guid Guid { get; init; }
        public required string DeviceType { get; init; }
    }

    public class InitializePeripheralInfo
    {
        public Guid Guid { get; init; }
        public PeripheralPhysicalType Type { get; init; }
    }
    
}
