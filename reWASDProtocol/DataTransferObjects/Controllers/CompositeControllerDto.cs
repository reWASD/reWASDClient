/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

namespace reWASDProtocol.DataTransferObjects.Controllers
{
    public class CompositeControllerDto : BaseControllerDto
    {
        /// <summary>
        /// Composite contains a list of children.
        /// Maximum count of children is 4. But list always contains 4 elements. Absent children are null.
        /// </summary>
        public List<BaseControllerDto?> Children { get; init; } = new();
    }
}
