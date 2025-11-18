/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Infrastructure
{
    public class BatteryInfo
    {
        public bool IsLevelInPercents { get; set; }
        public byte LevelInPercents { get; set; }
        public BatteryLevel Level { get; set; }
        public BatteryChargingState ChargingState { get; set; }
    }
}
