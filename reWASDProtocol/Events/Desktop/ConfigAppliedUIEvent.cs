/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Events.Desktop
{
    public class ConfigAppliedUIEvent(Guid controllerGuid, string controllerDisplayName, string gameName, string configName, Slot slot)
        : BaseControllerEvent(controllerGuid, controllerDisplayName, EventType.UIConfigApplied)
    {
        public Slot Slot { get; init; } = slot;
        public string GameName { get; init; } = gameName;
        public string ConfigName { get; init; } = configName;
    }
}
