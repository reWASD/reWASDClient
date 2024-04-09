/*
 *    Http protocol data structure.
 *
 *    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
 */

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Infrastructure
{
    public class OutputGamepadInfo
    {
        public VirtualGamepadType? VirtualGamepadType { get; set; }
        public ulong PhysicalControllerId { get; set; }

        public OutputGamepadInfo()
        {
        }

        public OutputGamepadInfo(object outputGamepad)
        {
            switch (outputGamepad)
            {
                case VirtualGamepadType virtualGamepadType:
                    VirtualGamepadType = virtualGamepadType;
                    break;
                case ulong physicalControllerId:
                    PhysicalControllerId = physicalControllerId;
                    break;
            }
        }
    }
}
