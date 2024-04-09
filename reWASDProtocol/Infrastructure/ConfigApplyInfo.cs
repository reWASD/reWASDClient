/*
 *    Http protocol data structure.
 *
 *    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
 */

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Infrastructure
{
    public class ConfigApplyInfo
    {
        public Guid? ControllerGuid { get; init; }
        public required string Path { get; init; }
        public EnableRemapBundle? Bundle { get; set; }
        public Slot Slot { get; init; }
    }

}
