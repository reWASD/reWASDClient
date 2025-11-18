/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/


namespace reWASDProtocol.Events.Desktop
{
    public class ConfigDeletedEvent(string clientId, Guid id) : IBaseEvent
    {
        public EventType Type => EventType.ConfigDeleted;
        public string ClientId { get; init; } = clientId;
        public Guid Id { get; init; } = id;
    }
}
