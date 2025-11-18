/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.DataTransferObjects.Controllers;

namespace reWASDProtocol.Events.Desktop
{
    public class ControllerChangedEvent(BaseControllerDto controller) : IBaseEvent
    {
        public EventType Type => EventType.ControllerChanged;
        public BaseControllerDto Controller { get; init; } = controller;
    }
}
