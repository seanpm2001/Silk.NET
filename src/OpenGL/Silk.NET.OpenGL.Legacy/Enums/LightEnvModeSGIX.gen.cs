// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "LightEnvModeSGIX")]
    public enum LightEnvModeSGIX : int
    {
        [System.Obsolete]
        [NativeName("Name", "GL_ADD")]
        Add = 0x104,
        [NativeName("Name", "GL_REPLACE")]
        Replace = 0x1E01,
        [System.Obsolete]
        [NativeName("Name", "GL_MODULATE")]
        Modulate = 0x2100,
    }
}
