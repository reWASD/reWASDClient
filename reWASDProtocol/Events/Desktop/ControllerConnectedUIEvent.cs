/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.DataTransferObjects.Controllers;

namespace reWASDProtocol.Events.Desktop
{
    public class ControllerConnectedUIEvent : IBaseEvent
    {
        public EventType Type => EventType.UIControllerAdded;
        public BaseControllerDto Controller;

        public ControllerConnectedUIEvent(BaseControllerDto controller)
        {
            Controller = controller;
        }
    }
}
