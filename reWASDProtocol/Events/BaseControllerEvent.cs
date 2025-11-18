/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events
{
    public abstract class BaseControllerEvent(Guid controllerGuid, string controllerDisplayName, EventType eventType) : IBaseEvent
    {
        public EventType Type => eventType;
        public Guid ControllerGuid { get; init; } = controllerGuid;
        public string ControllerDisplayName { get; init; } = controllerDisplayName;
    }
}
