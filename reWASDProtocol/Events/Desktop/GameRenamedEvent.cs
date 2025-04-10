/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class GameRenamedEvent : IBaseEvent
    {
        public GameRenamedEvent(Guid id, string newName)
        {
            Id = id;
            NewName = newName;
        }

        public EventType Type => EventType.GameRenamed;
        public Guid Id { get; init; }
        public string NewName { get; init; }
    }
}
