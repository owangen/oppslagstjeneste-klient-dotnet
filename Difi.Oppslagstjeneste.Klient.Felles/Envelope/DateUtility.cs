﻿using System;

namespace Difi.Oppslagstjeneste.Klient.Felles.Envelope
{
    internal static class DateUtility
    {
        public const string DateFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffZ";

        public static string DateForFile()
        {
            return DateTime.Now.ToString("yyyy'-'MM'-'dd HH'.'mm'.'ss");
        }
    }
}
