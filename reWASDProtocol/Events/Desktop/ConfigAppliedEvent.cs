/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Events.Desktop
{
    public class ConfigAppliedEvent: BaseControllerEvent
    {
        public Slot Slot { get; init; }
        public Guid Id { get; init; }
        public ConfigAppliedEvent(Guid controllerGuid, string controllerDisplayName, Guid id, Slot slot): 
            base(controllerGuid, controllerDisplayName, EventType.ConfigApplied)
        {
            Slot = slot;
            Id = id;
        }
    }
}
