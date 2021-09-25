// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkFenceImportFlagsKHR")]
    public enum FenceImportFlagsKHR : int
    {
        [NativeName("Name", "VK_FENCE_IMPORT_TEMPORARY_BIT")]
        FenceImportTemporaryBit = 1,
    }
}