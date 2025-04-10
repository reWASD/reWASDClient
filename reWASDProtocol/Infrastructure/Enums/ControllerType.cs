/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using Newtonsoft.Json.Converters;
using System.ComponentModel;
using Newtonsoft.Json;

namespace reWASDProtocol.Infrastructure.Enums
{
    // DO NOT CHANGE ORDER OF ITEMS
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ControllerType
    {
        [Description("Unknown")]
        Unknown = 0,
        [Description("Xbox 360")]
        Xbox360 = 1,
        [Description("Xbox One")]
        XboxOne = 2,
        [Description("Xbox Elite")]
        XboxElite = 3,
        [Description("DualShock 4")]                // DualShock 4 USB
        SonyDualshock4USB = 4,
        [Description("DualShock 3")]
        SonyDualshock3 = 5,
        [Description("DualShock 3")]                // Sony Dualshock 3 on Mayflash PS3 Controller Adapter
        SonyDualshock3Adapter = 6, 
        [Description("Nintendo Switch Pro")]        // Nintendo Switch Pro
        NintendoSwitchPro = 7,
        [Description("Nintendo Switch Wired")]      // Family of wired 3rd party controllers for Nintendo Switch (eg. PowerA, HORI Pad etc)
        NintendoSwitchWired = 8,
        [Description("Nintendo Switch Joy-Con L")]  // Joy-Con L for Nintendo Switch
        NintendoSwitchJoyConL = 9,
        [Description("Nintendo Switch Joy-Con R")]  // Joy-Con R for Nintendo Switch
        NintendoSwitchJoyConR = 10,
        [Description("PS3 Navigation")]             // Playstation Navigation controller
        SonyPs3Navigation = 11,
        [Description("Xbox Elite 2")]
        XboxElite2 = 12,
        [Description("Google Stadia")]
        GoogleStadia = 13,
        [Description("DualShock 4")]                // DualShock 4 Bluetooth
        SonyDualshock4BT = 14,
        [Description("Logitech")]                   // Logitech
        Logitech = 15,
        [Description("Steam")]                      // Steam
        Steam = 16,
        [Description("GameCube")]                   // GameCube
        GameCube = 17,
        [Description("GameCube")]                   // GameCube on MayFlash or compatible adapter (DI mode)
        GameCubeMayFlash = 18,
        [Description("Azeron")]                     // Azeron
        Azeron = 19,
        [Description("DualSense")]                  // DualSense USB
        SonyDualSenseUSB = 20,
        [Description("DualSense")]                  // DualSense Bluetooth
        SonyDualSenseBT = 21,
        [Description("Xbox Series X | S")]
        XboxOneX = 22,
        [Description("NVidia Shield 2015")]
        NVidiaShield = 23,
        [Description("NVidia Shield 2017")]
        NVidiaShield2 = 24,
        [Description("8BitDo")]
        _8BitDo = 25,
        [Description("Ipega 9023")]
        Ipega9023 = 26,
        [Description("PowerA MOGA XP5-X Plus")]
        PowerAMOGAXP5AP = 27,
        [Description("Azeron Cyborg")]              // Azeron Cyborg
        AzeronCyborg = 28,
        [Description("Thrustmaster Dual Analog 4")] //Thrustmaster Dual Analog 4
        ThrustmasterDA4 = 29,
        [Description("SNES")]                       // SNES USB
        SNES = 30,
        [Description("WiiRemote")]                  // WiiRemote
        WiiRemote = 31,
        [Description("WiiUPro")]                    // WiiUPro
        WiiUPro = 32,
        [Description("WiiNunchuk")]                 // WiiNunchuk
        WiiNunchuk = 33,
        [Description("WiiClassic")]                 // WiiClassic
        WiiClassic = 34,
        [Description("Generic 12B")]                // Generic 12B
        Generic12B = 35,
        [Description("Razer Raiju Mobile")]         // RazerRaijuMobile
        RazerRaijuMobile = 36,
        [Description("Flydigi Apex 1")]             // Flydigi Apex 1
        FlydigiApex1 = 37,
        [Description("Flydigi Apex 2")]             // Flydigi Apex 2
        FlydigiApex2 = 38,
        [Description("Flydigi Vader 2")]            // Flydigi Vader 2
        FlydigiVader2 = 39,
        [Description("Flydigi Vader 2 Pro")]        // Flydigi Vader 2 Pro
        FlydigiVader2Pro = 40,
        [Description("Generic 13B")]                // Generic 13B
        Generic13B = 41,
        [Description("Generic 14B")]                // Generic 14B
        Generic14B = 42,
        [Description("Generic 12B Dual Trigger")]   // Generic 12B dual trigger
        Generic12BDualTrigger = 43,
        [Description("SNES NSO")]                   // SNES NSO
        SNESNso = 44,
        [Description("NES International (L)")]      // NES International (L)
        NESNsoWestL = 45,
        [Description("NES International (R)")]      // NES International (R)
        NESNsoWestR = 46,
        [Description("NES Japanese (L)")]           // NES NSO Japan (L)
        NESNsoJapanL = 47,
        [Description("NES Japanese (R)")]           // NES NSO Japan (R)
        NESNsoJapanR = 48,
        [Description("Switch Online N64")]          // Switch Online N64
        SwitchOnlineN64 = 49,
        [Description("SEGA Genesis")]               // Sega NSO
        SegaNso = 50,
        [Description("Razer Wolverine V2")]         // Razer Wolverine V2
        RazerWolverine2 = 51,
        [Description("Xim Nexus")]                  // Xim Nexus USB
        XimNexusUSB = 52,
        [Description("Xim Nexus")]                  // Xim Nexus Bluetooth
        XimNexusBT = 53,
        [Description("Azeron Cyro")]                // Azeron Cyro
        AzeronCyro = 54,
        [Description("GameSir G7")]                 // GameSir G7
        GameSirG7 = 55, 
        [Description("DualSense Edge")]             // DualSense Edge USB
        SonyDualSenseEdgeUSB = 56,
        [Description("DualSense Edge")]             // DualSense Edge Bluetooth
        SonyDualSenseEdgeBT = 57,
        [Description("HORI Wired Gamepad PS4")]     // Hori Wired Mini Gamepad for PS4
        HoriMiniDualshock4 = 58,
        [Description("HORI Fighting Commander OCTA PS5")] // HORI Fighting Commander OCTA for PS5
        HoriFightingCommanderOctaSonySvgPS5 = 59,
        [Description("HORI Fighting Commander OCTA PS4")] // HORI Fighting Commander OCTA for PS4
        HoriFightingCommanderOctaSonySvgPS4 = 60,
        [Description("HORI Fighting Commander OCTA PC")]  // HORI Fighting Commander OCTA for PC (Xbox360)
        HoriFightingCommanderOctaSonySvgPC = 61,
        [Description("Flydigi Apex 3")]             // Flydigi Apex 3
        FlydigiApex3 = 62,
        [Description("Steam Deck")]                 // Steam Deck
        SteamDeck = 63,
        [Description("HORI Fighting Commander OCTA Xbox")] // HORI Fighting Commander OCTA for Xbox
        HoriFightingCommanderOctaXboxSvg = 64,
        [Description("Flydigi Vader 3 Pro")]        // Flydigi Vader 3 Pro
        FlydigiVader3Pro = 65,
        [Description("DarkWalker ShotPad")]         // DarkWalker ShotPad
        DarkWalkerShotPad = 66,
        [Description("Azeron Cyborg V2")]           // Azeron Cyborg V2 (2024 version with additional button)
        AzeronCyborgV2 = 67,
        [Description("HORI Wireless HORIPAD for Steam")] // HORI Wireless HORIPAD for Steam
        HoripadSteam = 68,
        [Description("Flydigi Vader 4 Pro")]        // Flydigi Vader 4 Pro
        FlydigiVader4Pro = 69,
        [Description("Alpakka")]                    // Alpakka
        Alpakka = 70,
        [Description("Flydigi Apex 4")]             // Flydigi Apex 4
        FlydigiApex4 = 71,

        // Special controllers
        [Description("Sensor")]
        Sensor = 100,

        // Handheld devices
        [Description("AYANEO 2S")]                  // AYANEO 2S
        Ayaneo2S = 200,
        [Description("AOKZOE A1")]                  // AOKZOE A1
        AokzoeA1 = 201,
        [Description("ASUS ROG Ally")]              // ASUS ROG Ally
        AsusRogAlly = 202,
        [Description("ASUS ROG Ally X")]            // ASUS ROG Ally X
        AsusRogAllyX = 203,

        [Description("Mobile Gamepad")]
        EngineController = 500, // Is used by Service. Represents "gamepad" layout in UI

        // Virtual layout values for EngineController. Service doesnt know about them, they are used only in UI to display proper layout and icons
        // All layout types must be prefixed with "EngineController"
        [Description("Mobile Touchpad")]
        EngineController_Touchpad = 501,
        [Description("Mobile Control Pad")]
        EngineController_ControlPad = 502,
        [Description("Mobile Keyboard")]
        EngineController_Keyboard = 503,
        [Description("Mobile Mouse")]
        EngineController_Mouse = 504,
        [Description("Mobile Mouse Touchpad")]
        EngineController_MouseTouchpad = 505,
        //

        [Description("Virtual Input Keyboard")]
        EngineController_VirtualInputKeyboard = 600,    // Virtual Input Keyboard
        [Description("Virtual Input Mouse")]
        EngineController_VirtualInputMouse = 601,       // Virtual Input Mouse

        [Description("Keyboard")]
        Keyboard = 1000,
        [Description("Mouse")]
        Mouse,
        [Description("Media keyboard")]
        Consumer,
        [Description("System")]
        System,
        [Description("HID compatible")]
        HID = 2000,
        [Description("Max Keyboard")]
        MaxKeyboard = 5000,
        [Description("Max Mouse")]
        MaxMouse = 5001
    }
}
