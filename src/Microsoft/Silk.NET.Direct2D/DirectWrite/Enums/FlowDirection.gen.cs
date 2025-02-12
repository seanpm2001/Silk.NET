// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FLOW_DIRECTION")]
    public enum FlowDirection : int
    {
        [NativeName("Name", "DWRITE_FLOW_DIRECTION_TOP_TO_BOTTOM")]
        TopToBottom = 0x0,
        [NativeName("Name", "DWRITE_FLOW_DIRECTION_BOTTOM_TO_TOP")]
        BottomToTop = 0x1,
        [NativeName("Name", "DWRITE_FLOW_DIRECTION_LEFT_TO_RIGHT")]
        LeftToRight = 0x2,
        [NativeName("Name", "DWRITE_FLOW_DIRECTION_RIGHT_TO_LEFT")]
        RightToLeft = 0x3,
    }
}
