/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.DataTransferObjects.Controllers
{
    public record PeripheralControllerDto : BaseControllerDto
    {
        /// <summary>
        /// List of controllers that make up a peripheral device
        /// </summary>
        public List<ControllerDto> Controllers { get; init; } = [];

        public PeripheralPhysicalType PeripheralPhysicalType { get; init; }
        public PeripheralType PeripheralType { get; init; }
    }
}
