/*
*    Infrastructure enumaration.
*
*    Copyright (c) 2023 Disc Soft FZE LLC. All rights reserved.
*/

using System.Text.Json.Serialization;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<ImportConfigStatus>))]
    public enum ImportConfigStatus
    {
        Ok, 
        PathTooLong, 
        ConfigAlreadyExist, 
        Failed
    }
}
