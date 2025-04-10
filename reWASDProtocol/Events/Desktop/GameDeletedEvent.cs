/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class GameDeletedEvent : IBaseEvent
    {
        public EventType Type => EventType.GameDeleted;
        public string ClientId { get; set; }
        public Guid Id { get; set; }

        public GameDeletedEvent(string clientId, Guid id)
        {
            ClientId = clientId;
            Id = id;
        }
    }
}
