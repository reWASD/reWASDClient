/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class HoneypotPairingRejectedEvent : IBaseEvent
    {
        public EventType Type => EventType.HoneypotPairingRejected;
        public ulong MacAddress{ get; set; }

        public HoneypotPairingRejectedEvent(ulong macAddress)
        {
            MacAddress = macAddress;
        }
    }
}
