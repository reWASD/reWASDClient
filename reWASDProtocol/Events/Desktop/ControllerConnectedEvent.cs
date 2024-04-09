/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.DataTransferObjects.Controllers;

namespace reWASDProtocol.Events.Desktop
{
    public class ControllerConnectedEvent : IBaseEvent
    {
        public EventType Type => EventType.ControllerAdded;
        public BaseControllerDto Controller;

        public ControllerConnectedEvent(BaseControllerDto controller)
        {
            Controller = controller;
        }
    }
}
