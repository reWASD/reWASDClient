/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.DataTransferObjects
{
    public class PingInfo
    {
        public ulong MinPingTime { get; init; }
        public ulong MaxPingTime { get; init; }
        public ulong AvgPingTime { get; init; }
        public uint NumPingPacketsSent { get; init; }
    }
}
