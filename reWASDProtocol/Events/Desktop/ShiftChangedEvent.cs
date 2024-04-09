/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class ShiftChangedEvent : BaseControllerEvent
    {
        /// <summary>
        /// Shift number. 0 for Main
        /// </summary>
        public int Shift;

        public ShiftChangedEvent(Guid controllerGuid, string controllerDisplayName, int shift) : 
            base(controllerGuid, controllerDisplayName, EventType.ShiftChanged)
        {
            Shift = shift;
        }
    }
}