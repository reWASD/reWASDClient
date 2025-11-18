/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class ConfigSavedEvent(string clientId, Guid id) : IBaseEvent
    {
        public EventType Type => EventType.ConfigSaved;
        public string ClientId { get; init; } = clientId;
        public Guid Id { get; init; } = id;
    }
}
