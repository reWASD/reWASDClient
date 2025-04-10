/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class RemapOffUIEvent : BaseControllerEvent
    {
        public RemapOffUIEvent(Guid controllerGuid, string deviceName) : 
            base(controllerGuid, deviceName, EventType.UIRemapOff)
        {
        }
    }
}
