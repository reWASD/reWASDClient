/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Events.Desktop;
using System.Text.Json.Serialization;

namespace reWASDProtocol.Events
{
    [JsonPolymorphic]

    [JsonDerivedType(typeof(HeartbeatEvent), "Heartbeat")]
    [JsonDerivedType(typeof(ServiceProfilesChangedEvent), "ServiceProfilesChanged")]
    [JsonDerivedType(typeof(ConfigAppliedEvent), "ConfigApplied")]
    [JsonDerivedType(typeof(SlotChangedEvent), "SlotChanged")]
    [JsonDerivedType(typeof(RemapStateChangedEvent), "RemapStateChanged")]
    [JsonDerivedType(typeof(BatteryLevelChangedEvent), "BatteryLevel")]
    [JsonDerivedType(typeof(ShiftChangedEvent), "ShiftChanged")]
    [JsonDerivedType(typeof(ControllerConnectedEvent), "ControllerAdded")]
    [JsonDerivedType(typeof(ControllerChangedEvent), "ControllerChanged")]
    [JsonDerivedType(typeof(ControllerDisconnectedEvent), "ControllerRemoved")]
    [JsonDerivedType(typeof(AllControllersDisconnectedEvent), "AllControllersDisconnected")]
    [JsonDerivedType(typeof(ControllerStateChangedEvent), "ControllerStateChanged")]
    [JsonDerivedType(typeof(ConfigSavedEvent), "ConfigSaved")]
    [JsonDerivedType(typeof(GyroCalibrationFinishedEvent), "GyroCalibrationFinished")]
    //[JsonDerivedType(typeof(LicenseChangedEvent), "LicenseChanged")]
    [JsonDerivedType(typeof(ProfileRelationsChangedByEngineEvent), "ProfileRelationsChangedByEngine")]
    [JsonDerivedType(typeof(ConfigRenamedEvent), "ConfigRenamed")]
    [JsonDerivedType(typeof(ConfigDeletedEvent), "ConfigDeleted")]
    [JsonDerivedType(typeof(GameRenamedEvent), "GameRenamed")]
    [JsonDerivedType(typeof(GameDeletedEvent), "GameDeleted")]
    [JsonDerivedType(typeof(ExternalDevicesChangedEvent), "ExternalDevicesChanged")]
    //[JsonDerivedType(typeof(ExternalDeviceOutdatedEvent), "ExternalDeviceFirmwareOutdated")]
    [JsonDerivedType(typeof(CompositeSettingsChangedEvent), "CompositeSettingsChanged")]
    [JsonDerivedType(typeof(HoneypotPairingRejectedEvent), "HoneypotPairingRejected")]
    [JsonDerivedType(typeof(AllControllersDisconnectedUIEvent), "UIAllControllersDisconnected")]
    [JsonDerivedType(typeof(BatteryLevelChangedUIEvent), "UIBatteryLevel")]
    [JsonDerivedType(typeof(ConfigAppliedUIEvent), "UIConfigApplied")]
    [JsonDerivedType(typeof(ControllerConnectedUIEvent), "UIControllerAdded")]
    [JsonDerivedType(typeof(ControllerDisconnectedUIEvent), "UIControllerRemoved")]
    [JsonDerivedType(typeof(RemapOffUIEvent), "UIRemapOff")]
    [JsonDerivedType(typeof(ShiftHideUIEvent), "UIShiftHide")]
    [JsonDerivedType(typeof(ShiftShowUIEvent), "UIShiftShow")]
    [JsonDerivedType(typeof(SlotChangedUIEvent), "UISlotChanged")]
    public interface IBaseEvent
    {
        EventType Type { get; }
    }
}
