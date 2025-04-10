/*
 *    Http protocol data structure.
 *
 *    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
 */

namespace reWASDProtocol.DataTransferObjects
{
    public class HttpVersion
    {
        /**
         * !!!!!!! DO NOT MODIFY PROPERTY !!!!!!!!
         * This prtoperty should be consistent across all versions of API: v1, v2, v3 etc
         */
        public string Version => Constants.VERSION_PROTOCOL;
    }
}
