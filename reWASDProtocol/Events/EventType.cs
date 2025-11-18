/*
 *    Http protocol data structure.
 *
 *    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
 */

using System.Text.Json.Serialization;

namespace reWASDProtocol.Events
{
    [JsonConverter(typeof(JsonStringEnumConverter<EventType>))]
    public enum EventType
    {
        // data events. used to notify client that something is changed and needs to be updated
        Heartbeat,
        ServiceProfilesChanged,
        ConfigApplied,
        SlotChanged,
        RemapStateChanged,
        BatteryLevel,
        ShiftChanged,
        ControllerAdded,
        ControllerChanged,
        ControllerRemoved,
        ControllerStateChanged,
        AllControllersDisconnected,
        ConfigSaved,
        ShiftShow,
        ShiftHide,
        GyroCalibrationFinished,
        LicenseChanged,
        ProfileRelationsChangedByEngine,
        ConfigRenamed,
        ConfigDeleted,
        GameRenamed,
        GameDeleted,
        ExternalDevicesChanged,
        ExternalDeviceFirmwareOutdated,
        CompositeSettingsChanged,
        HoneypotPairingRejected,
        PreferencesChanged,
        ExclusiveAccessChanged,

        // UI Events. prefixed with capital UI. used to display messages to user
        UIAllControllersDisconnected = 1000, 
        UIBatteryLevel,
        UIConfigApplied,
        UIControllerAdded,
        UIControllerRemoved,
        UIRemapOff,
        UIShiftHide,
        UIShiftShow,
        UISlotChanged,
    }
}
