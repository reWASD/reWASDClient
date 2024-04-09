/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Infrastructure
{
    public readonly struct TriggersInfo
    {
        public bool HasAdaptive { get; init; }
        public bool HasAnalog { get; init; }
    }
}
