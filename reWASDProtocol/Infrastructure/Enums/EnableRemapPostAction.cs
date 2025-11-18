/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<EnableRemapPostAction>))]
    public enum EnableRemapPostAction
    {
        None,
        RefreshGames, // when config is not existent
    }
}
