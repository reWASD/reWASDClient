/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/


namespace reWASDProtocol.Events.Desktop
{
    public class ConfigDeletedEvent : IBaseEvent
    {
        public EventType Type => EventType.ConfigDeleted;
        public string ClientId { get; init; }
        public Guid Id { get; init; }

        public ConfigDeletedEvent(string clientId, Guid id)
        {
            ClientId = clientId;
            Id = id;
        }
    }
}
