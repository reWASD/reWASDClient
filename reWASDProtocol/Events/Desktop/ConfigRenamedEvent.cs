/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.DataTransferObjects;

namespace reWASDProtocol.Events.Desktop
{
    public class ConfigRenamedEvent : IBaseEvent
    {
        public ConfigRenamedEvent(Guid id, string newName, string newPath)
        {
            Id = id;
            NewName = newName;
            NewPath = newPath;
        }

        public EventType Type => EventType.ConfigRenamed;
        public Guid Id { get; init; }
        public string NewName { get; init; }
        public string NewPath { get; init; }
    }
}
