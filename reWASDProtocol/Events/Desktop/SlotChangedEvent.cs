/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Events.Desktop
{
    public class SlotChangedEvent : BaseControllerEvent
    {
        public Slot Slot;
        public string? GameName;
        public string? ConfigName;

        public SlotChangedEvent(Guid controllerGuid, string controllerDisplayName, Slot slot, string? gameName, string? configName) : 
            base(controllerGuid, controllerDisplayName, EventType.SlotChanged)
        {
            GameName = gameName;
            ConfigName = configName;
            Slot = slot;
        }
    }
}
