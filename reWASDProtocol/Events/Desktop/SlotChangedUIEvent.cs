/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Events.Desktop
{
    public class SlotChangedUIEvent(Guid controllerGuid, string controllerDisplayName, Slot slot, string? gameName, string? configName)
        : BaseControllerEvent(controllerGuid, controllerDisplayName, EventType.UISlotChanged)
    {
        public Slot Slot { get; init; } = slot;
        public string? GameName { get; init; } = gameName;
        public string? ConfigName { get; init; } = configName;
    }
}
