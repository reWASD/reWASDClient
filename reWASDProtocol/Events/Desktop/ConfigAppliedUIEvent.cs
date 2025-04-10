/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Events.Desktop
{
    public class ConfigAppliedUIEvent : BaseControllerEvent
    {
        public Slot Slot;
        public string GameName;
        public string ConfigName;

        public ConfigAppliedUIEvent(Guid controllerGuid, string controllerDisplayName, string gameName, string configName, Slot slot) : 
            base(controllerGuid, controllerDisplayName, EventType.UIConfigApplied)
        {
            Slot = slot;
            GameName = gameName;
            ConfigName = configName;
        }
    }
}
