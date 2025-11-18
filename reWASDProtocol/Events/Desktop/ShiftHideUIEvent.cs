/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class ShiftHideUIEvent(string id) : IBaseEvent
    {
        public EventType Type => EventType.UIShiftHide;
        public string ID { get; init; } = id;
    }
}
