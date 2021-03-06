﻿using System;

namespace Generics
{
    class Utils
    {
        public static T Max<T>(T a, T b) where T : IComparable 
        {
            return (a.CompareTo(b) > 0) ? a : b;
        }
    }
}