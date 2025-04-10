/*
 *    Http protocol data structure.
 *
 *    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace reWASDProtocol.Events
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventType
    {
        // data events. used to notify client that somewthing is changed and needs to be updated
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
