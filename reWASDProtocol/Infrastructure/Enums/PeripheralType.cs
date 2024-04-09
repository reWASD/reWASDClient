/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeripheralType
    {
        Invalid = 0,                        // 0x0000
        Keyboard = 1,                       // 0x0001
        Mouse = 2,                          // 0x0010
        KeyboardMouse = 3,                  // 0x0011
        KeyboardConsumer = 5,               // 0x0101
        InvalidConsumer = 4,                // 0x0100
        MouseConsumer = 6,                  // 0x0110
        KeyboardMouseConsumer = 7,          // 0x0111
        InvalidSystem = 8,                  // 0x1000
        KeyboardSystem = 9,                 // 0x1001
        MouseSystem = 10,                   // 0x1010
        KeyboardMouseSystem = 11,           // 0x1011
        InvalidConsumerSystem = 12,         // 0x1100
        KeyboardConsumerSystem = 13,        // 0x1101
        MouseConsumerSystem = 14,           // 0x1110
        KeyboardMouseConsumerSystem = 15    // 0x1111
    }
}
