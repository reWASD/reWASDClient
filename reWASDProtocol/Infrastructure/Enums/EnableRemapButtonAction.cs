/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace reWASDProtocol.Infrastructure.Enums
{
    /**
     * List of unique identifiers. for each case and each button - this id should be unique, no matter if button text is matching
     */
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnableRemapButtonAction
    {
        NoAction = 0, // pressing this button should not result calling EnableRemap again. It's just for information. Usually with text like "Cancel" or "OK"
        LimitedConfigWithLackOfFeature = 1, // "Apply as is" config without feature
        UnplugPhysicalControllerToAvoidConflict = 2,
        SteamExtended = 3,
        UnmappedMouseApplyWithoutConfigChanges = 4,
        UnmappedMouseApplyWithConfigChanges = 5,
        UnmappedMouseApplyInCaseConfigCantBeChanged = 6,
        UnmappedMouseInformational = 7,
        ConfigIsEmpty = 8,
        ConfigNotFound = 9,
        ErrorParsingConfig = 10,
        TooManyLongCombos = 11,
        UsingCheatsInformational = 12,
        ExternalDeviceError = 13,
        UdpServerError = 14,

        LimitedConfigTryTrialFeature = 15,          // UI button. Mobile client works only with LimitedConfigWithLackOfFeature in 6.0 release.
        LimitedConfigDoNotTryTrialFeature = 16,     // UI button. Mobile client works only with LimitedConfigWithLackOfFeature in 6.0 release.

        JumpToLayerDeadEnd = 17,
        AmiiboIsNotValid = 18,
        PreviousAmiiboInUse = 19,
        VirtualUsbHubError = 20,
    }
}
