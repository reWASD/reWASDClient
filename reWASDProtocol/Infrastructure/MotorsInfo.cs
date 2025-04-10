/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Infrastructure
{
    public readonly struct MotorsInfo
    {
        public bool HasMotors { get; init; }
        public bool HasTriggerMotors { get; init; }
        public bool HasAccurateRumble { get; init; }
    }
}
