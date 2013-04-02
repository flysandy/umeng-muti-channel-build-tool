﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using CommonTools;

namespace UmengWidget.Common
{
    public class Apktool
    {
        private static readonly string TEMP = Path.Combine(Environment.CurrentDirectory, "widget_temp");

        public static DecodedApkStruct Decode(string apk)
        {
            Aapt.DecodeApk(apk, TEMP);

            return new DecodedApkStruct( TEMP );
        }

        public static void Build(string dstApk)
        {
            Aapt.BuildApk(TEMP, dstApk);
        }
    }
}