﻿using System;

namespace Digimezzo.Foundation.WPF.Utils
{
    public class UriUtils
    {
        public static Uri MakePackUri<T>(string relativeFile)
        {
            var a = typeof(T).Assembly;
            var assemblyShortName = a.ToString().Split(',')[0];
            var uriString = $"pack://application:,,,/{assemblyShortName};component/{relativeFile}";

            return new Uri(uriString);
        }
    }
}
