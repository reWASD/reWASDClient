/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Events.Desktop
{
    public class ConfigAppliedEvent(Guid controllerGuid, string controllerDisplayName, Guid id, Slot slot)
        : BaseControllerEvent(controllerGuid, controllerDisplayName, EventType.ConfigApplied)
    {
        public Slot Slot { get; init; } = slot;
        public Guid Id { get; init; } = id;
    }
}
