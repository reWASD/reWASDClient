/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Events.Desktop
{
    public class RemapStateChangedEvent(Guid controllerGuid, string controllerDisplayName, RemapState remapState)
        : BaseControllerEvent(controllerGuid, controllerDisplayName, EventType.RemapStateChanged)
    {
        public RemapState RemapState { get; init; } = remapState;
    }
}
