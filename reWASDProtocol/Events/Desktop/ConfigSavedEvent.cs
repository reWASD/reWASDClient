/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class ConfigSavedEvent : IBaseEvent
    {
        public EventType Type => EventType.ConfigSaved;
        public string ClientId { get; init; }
        public Guid Id { get; init; }

        public ConfigSavedEvent(string clientId, Guid id)
        {
            ClientId = clientId;
            Id = id;
        }
    }
}
