/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events
{
    public abstract class BaseControllerEvent : IBaseEvent
    {
        public EventType Type { get; init; }
        public Guid ControllerGuid;
        public string ControllerDisplayName;

        protected BaseControllerEvent(Guid controllerGuid, string controllerDisplayName, EventType eventType)
        {
            Type = eventType;
            ControllerGuid = controllerGuid;
            ControllerDisplayName = controllerDisplayName;
        }
    }
}
