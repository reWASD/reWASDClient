/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;
using reWASDProtocol.Infrastructure;

namespace reWASDProtocol.DataTransferObjects.Controllers
{
    public class ControllerDto : BaseControllerDto
    {
        public ControllerType ControllerType { get; init; }
        public ConnectionType ConnectionType { get; init; }
        public ManufacturerInfo ManufacturerInfo { get; init; }
        public VersionInfoDto FirmwareVersion { get; init; }
        public TriggersInfo TriggersInfo { get; init; }
        public MotorsInfo MotorsInfo { get; init; }
        public SensorsInfo SensorsInfo { get; init; }
        public BatteryInfo? BatteryInfo { get; init; }
        public bool IsMasterAddressPresent { get; init; }
        public ulong MasterBthAddr { get; init; }
        public bool IsBluetoothConnection { get; init; }
        public bool HasTouchpad { get; init; }
        public bool HasChatpad { get; init; }
        public bool IsExclusiveAccessSupported { get; init; }
        public bool IsRightHandDevice { get; init; }
        public bool IsPhysicalOutputAndDebugSupported { get; init; }
        public bool IsInvalidType { get; init; }
    }
}
