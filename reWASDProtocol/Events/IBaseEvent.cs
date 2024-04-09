/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events
{
    public interface IBaseEvent
    {
        EventType Type { get; }
    }
}
