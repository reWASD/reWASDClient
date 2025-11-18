/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure;

namespace reWASDProtocol.Events.Desktop
{
    public class BatteryLevelChangedEvent(Guid controllerGuid, string controllerDisplayName, BatteryInfo batteryInfo)
        : BaseControllerEvent(controllerGuid, controllerDisplayName, EventType.BatteryLevel)
    {
        public BatteryInfo BatteryInfo { get; init; } = batteryInfo;
    }
}
