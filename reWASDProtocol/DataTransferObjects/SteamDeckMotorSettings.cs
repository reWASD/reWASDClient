/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.DataTransferObjects
{
    public class SteamDeckMotorSettings
    {
        public bool LeftIsStrongIntensity { get; init; }
        public byte LeftIntensity { get; init; }
        public bool RightIsStrongIntensity { get; init; }
        public byte RightIntensity { get; init; }
    }
}
