﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchSite.External
{
    public static class Extension
    {
        public static string UppercaseFirst(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}