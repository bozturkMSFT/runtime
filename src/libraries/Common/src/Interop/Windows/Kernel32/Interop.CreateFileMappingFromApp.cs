// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern SafeMemoryMappedFileHandle CreateFileMappingFromApp(
            SafeFileHandle hFile,
            ref SECURITY_ATTRIBUTES SecurityAttributes,
            int PageProtection,
            long MaximumSize,
            string Name);

        [DllImport(Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern SafeMemoryMappedFileHandle CreateFileMappingFromApp(
            IntPtr hFile,
            ref SECURITY_ATTRIBUTES SecurityAttributes,
            int PageProtection,
            long MaximumSize,
            string Name);
    }
}
