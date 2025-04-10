/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnableRemapPostAction
    {
        None,
        RefreshGames, // when config is not existent
    }
}
