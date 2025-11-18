/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.DataTransferObjects;

namespace reWASDProtocol.Events.Desktop
{
    public class ShiftShowUIEvent(Guid controllerGuid, string controllerDisplayName, ShiftInfo shiftInfo, bool toggle, bool alwaysShow)
        : BaseControllerEvent(controllerGuid, controllerDisplayName, EventType.UIShiftShow)
    {
        public ShiftInfo ShiftInfo { get; init; } = shiftInfo;
        public bool Toggle { get; init; } = toggle;
        public bool AlwaysShow { get; init; } = alwaysShow;
    }
}
