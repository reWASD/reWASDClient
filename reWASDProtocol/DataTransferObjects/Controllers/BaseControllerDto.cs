/*
*    Http protocol data structure.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;
using reWASDProtocol.Infrastructure;
using System.Text.Json.Serialization;

namespace reWASDProtocol.DataTransferObjects.Controllers
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "DataType")]

    [JsonDerivedType(typeof(ControllerDto), typeDiscriminator: "Controller")]
    [JsonDerivedType(typeof(PeripheralControllerDto), typeDiscriminator: "PeripheralController")]
    [JsonDerivedType(typeof(CompositeControllerDto), typeDiscriminator: "CompositeController")]
    public abstract record BaseControllerDto
    {
        public Guid Guid { get; init; }
        public bool IsDebug { get; init; }
        public List<ulong> Ids { get; init; } = [];
        public List<ControllerType> Types { get; init; } = [];
        public ControllerFamily Family { get; init; }
        public bool IsOnline { get; init; }
        public RemapState RemapState { get; init; }
        public OutputGamepadInfo OutputGamepad { get; init; } = new();
        public Slot CurrentSlot { get; init; }
        public bool IsInsideCompositeDevice { get; init; }
        public bool HasLED { get; init; }
        public string? FriendlyName { get; init; }
        public string DisplayName { get; init; } = "";
        public bool CanReinitialize { get; init; }
        public string? InitializedDeviceType { get; init; }
        public bool IsInitialized { get; init; }
        public bool IsAmiiboApplied { get; init; }
    }
}
