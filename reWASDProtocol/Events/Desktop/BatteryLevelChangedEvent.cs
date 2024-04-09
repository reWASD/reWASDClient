/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure;

namespace reWASDProtocol.Events.Desktop
{
    public class BatteryLevelChangedEvent : BaseControllerEvent
    {
        public BatteryInfo BatteryInfo { get; init; }

        public BatteryLevelChangedEvent(Guid controllerGuid, string controllerDisplayName, BatteryInfo batteryInfo) : 
            base(controllerGuid, controllerDisplayName, EventType.BatteryLevel)
        {
            BatteryInfo = batteryInfo;
        }
    }
}
