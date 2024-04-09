/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Infrastructure
{
    public readonly struct MotorsInfo
    {
        public bool HasMotors { get; init; }
        public bool HasTriggerMotors { get; init; }
    }
}
