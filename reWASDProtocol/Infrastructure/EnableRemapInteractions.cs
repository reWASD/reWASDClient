/*
*    Http protocol data structure.
*
*    Copyright (c) 2025 Disc Soft FZE LLC. All rights reserved.
*/

using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.Infrastructure
{
    public class EnableRemapBundle
    {
        /**
         * List of all user responses
         */
        public List<EnableRemapButtonAction> UserActions { get; set; } = new();

        public bool IsUI { get; set; }
    }

    public class EnableRemapResponse
    {
        /**
         *  List of all dialogs to be displayed
         */
        public List<EnableRemapResponseDialog> Dialogs { get; set; } = new();

        /**
         *  Action to be executed after receiving of this response
         */
        public EnableRemapPostAction PostAction { get; set; }

        public bool IsSucceded { get; set; }

        /**
         *  True if EnableRemap shouldn't be re-called again
         */
        public bool DontReCallEnableRemap { get; set; }

    }

    public class EnableRemapResponseButton
    {
        /**
         * Localized button text
         */
        public string? Text { get; set; }

        /**
         * Unique button identifier
         */
        public EnableRemapButtonAction ButtonAction { get; set; }
    }

    public class EnableRemapResponseDialog
    {
        /**
         * Localized message to be displayed
         */
        public required string Message { get; set; }

        /**
         * List of all buttons to be displayed
         */
        public List<EnableRemapResponseButton> Buttons { get; set; } = new();

        /**
         * Default button number from the List to be selected in 'silent' mode, like in cmd
         */
        public int DefaultButtonNumber { get; set; } = -1;

        /**
         * Additional parameter for specific dialogs (buy url)
         */
        public string? AdditionalParameter { get; set; }

        /**
         * Additional license info for GUI
         */
        public string? LicenseInfo { get; set; }
    }
}