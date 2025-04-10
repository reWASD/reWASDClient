/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class AllControllersDisconnectedEvent : IBaseEvent
    {
        public EventType Type => EventType.AllControllersDisconnected;
    }
}
