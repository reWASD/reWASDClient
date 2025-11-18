/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class GameRenamedEvent(Guid id, string newName) : IBaseEvent
    {
        public EventType Type => EventType.GameRenamed;
        public Guid Id { get; init; } = id;
        public string NewName { get; init; } = newName;
    }
}
