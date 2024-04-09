/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure;

namespace reWASDProtocol.Events.Desktop
{
    public class BatteryLevelChangedUIEvent : BaseControllerEvent
    {
        public BatteryInfo BatteryInfo { get; init; }

        public BatteryLevelChangedUIEvent(Guid controllerGuid, string controllerDisplayName, BatteryInfo batteryInfo) :
            base(controllerGuid, controllerDisplayName, EventType.UIBatteryLevel)
        {
            BatteryInfo = batteryInfo;
        }
    }
}
