/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Events.Desktop
{
    public class SlotChangedUIEvent : BaseControllerEvent
    {
        public Slot Slot;
        public string? GameName;
        public string? ConfigName;

        public SlotChangedUIEvent(Guid controllerGuid, string controllerDisplayName, Slot slot, string? gameName, string? configName) : 
            base(controllerGuid, controllerDisplayName, EventType.UISlotChanged)
        {
            GameName = gameName;
            ConfigName = configName;
            Slot = slot;
        }
    }
}
