﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace BackupWarehouse.Models.Utils
{
    public static class FormHelpers
    {
        public static Point CenterWindow(this Control addControl, Control mainControl)
        {
            return new Point(mainControl.Width / 2 - addControl.Width / 2,
                             mainControl.Height / 2 - addControl.Height / 2);
        }

        public static string Reverse(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}