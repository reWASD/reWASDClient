/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class AllControllersDisconnectedUIEvent : IBaseEvent
    {
        public EventType Type => EventType.UIAllControllersDisconnected;
    }
}
