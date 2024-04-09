/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class GamepadStateChangedEvent : BaseControllerEvent
    {
        public bool IsOnline { get; set; }

        public GamepadStateChangedEvent(Guid controllerGuid, string controllerDisplayName, bool isOnline) : 
            base(controllerGuid, controllerDisplayName, EventType.ControllerStateChanged)
        {
            IsOnline = isOnline;
        }
    }
}
