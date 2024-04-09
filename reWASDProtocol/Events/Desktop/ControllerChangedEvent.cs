/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.DataTransferObjects.Controllers;

namespace reWASDProtocol.Events.Desktop
{
    public class ControllerChangedEvent : IBaseEvent
    {
        public EventType Type => EventType.ControllerChanged;
        public BaseControllerDto Controller;

        public ControllerChangedEvent(BaseControllerDto controller)
        {
            Controller = controller;
        }
    }
}
