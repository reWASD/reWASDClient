/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.DataTransferObjects;

namespace reWASDProtocol.Events.Desktop
{
    public class ShiftShowUIEvent : BaseControllerEvent
    {
        public ShiftInfo ShiftInfo;
        public bool Toggle;
        public bool AlwaysShow;

        [Obsolete("This property is obsolete and is used only for compatibility reasons")]
        public int Shift => ShiftInfo.Shift;

        public ShiftShowUIEvent(Guid controllerGuid, string controllerDisplayName, ShiftInfo shiftInfo, bool toggle, bool alwaysShow) : 
            base(controllerGuid, controllerDisplayName, EventType.UIShiftShow)
        {
            ShiftInfo = shiftInfo;
            Toggle = toggle;
            AlwaysShow = alwaysShow;
        }
    }
}
