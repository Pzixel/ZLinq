﻿using System;

namespace ZLinq.CommonInternal
{
    internal class Error
    {
        public static InvalidOperationException EmptyCollection => new InvalidOperationException("Collection is empty");
        public static InvalidOperationException MultipleElementsCollection => new InvalidOperationException("Collection contains more than one element");
    }
}
