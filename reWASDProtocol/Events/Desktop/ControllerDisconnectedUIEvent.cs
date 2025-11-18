/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class ControllerDisconnectedUIEvent(Guid controllerGuid, string controllerDisplayName)
        : BaseControllerEvent(controllerGuid, controllerDisplayName, EventType.UIControllerRemoved);
}
