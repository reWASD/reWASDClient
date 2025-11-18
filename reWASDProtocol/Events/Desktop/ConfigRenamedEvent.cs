/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.DataTransferObjects;

namespace reWASDProtocol.Events.Desktop
{
    public class ConfigRenamedEvent(Guid id, string newName, string newPath) : IBaseEvent
    {
        public EventType Type => EventType.ConfigRenamed;
        public Guid Id { get; init; } = id;
        public string NewName { get; init; } = newName;
        public string NewPath { get; init; } = newPath;
    }
}
