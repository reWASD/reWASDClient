/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Events.Desktop
{
    public class RemapStateChangedEvent : BaseControllerEvent
    {
        public RemapState RemapState;

        public RemapStateChangedEvent(Guid controllerGuid, string controllerDisplayName, RemapState remapState) : 
            base(controllerGuid, controllerDisplayName, EventType.RemapStateChanged)
        {
            RemapState = remapState;
        }
    }
}
