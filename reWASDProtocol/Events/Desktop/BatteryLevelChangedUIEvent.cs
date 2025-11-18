/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure;

namespace reWASDProtocol.Events.Desktop
{
    public class BatteryLevelChangedUIEvent(Guid controllerGuid, string controllerDisplayName, BatteryInfo batteryInfo)
        : BaseControllerEvent(controllerGuid, controllerDisplayName, EventType.UIBatteryLevel)
    {
        public BatteryInfo BatteryInfo { get; init; } = batteryInfo;
    }
}
