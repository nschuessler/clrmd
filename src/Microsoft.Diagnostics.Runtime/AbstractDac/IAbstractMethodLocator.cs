﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Diagnostics.Runtime.AbstractDac
{
    /// <summary>
    /// This interface is used to link methods to their parent types
    /// and instruction pointers to methods.
    ///
    /// This interface is optional.
    ///
    /// This interface is not "stable" and may change even in minor or patch
    /// versions of ClrMD.
    /// </summary>
    internal interface IAbstractMethodLocator
    {
        ulong GetMethodHandleContainingType(ulong methodDesc);
        ulong GetMethodHandleByInstructionPointer(ulong ip);
    }
}