/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Infrastructure
{
    public readonly struct SensorsInfo
    {
        public bool HasAccelerometer { get; init; }
        public bool HasGyroscope { get; init; }
        public bool IsGyroscopeManualCalibration { get; init; }
    }
}
