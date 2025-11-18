/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.DataTransferObjects.Controllers;

namespace reWASDProtocol.Events.Desktop
{
    public class ControllerConnectedEvent(BaseControllerDto controller) : IBaseEvent
    {
        public EventType Type => EventType.ControllerAdded;
        public BaseControllerDto Controller { get; init; } = controller;
    }
}
