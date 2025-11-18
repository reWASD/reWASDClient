/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.Events.Desktop
{
    public class ShiftChangedEvent(Guid controllerGuid, string controllerDisplayName, int shift)
        : BaseControllerEvent(controllerGuid, controllerDisplayName, EventType.ShiftChanged)
    {
        /// <summary>
        /// Shift number. 0 for Main
        /// </summary>
        public int Shift { get; init; } = shift;
    }
}