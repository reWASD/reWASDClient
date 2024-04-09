/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class ControllerDisconnectedUIEvent : BaseControllerEvent
    {
        public ControllerDisconnectedUIEvent(Guid controllerGuid, string controllerDisplayName) : 
            base(controllerGuid, controllerDisplayName, EventType.UIControllerRemoved)
        {
        }
    }
}
