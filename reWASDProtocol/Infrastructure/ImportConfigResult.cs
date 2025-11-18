/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Infrastructure
{
    public class ImportConfigResult
    {
        public string? ImportedConfigName { get; set; }
        public ImportConfigStatus Status { get; set; }
        public string? ErrorText { get; set; }
    }
}
