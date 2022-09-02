﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.TestPlatform.AdapterUtilities;

/// <summary>
/// Contants to help declare ManagedType and ManagedMethod test properties.
/// </summary>
#if PUBLIC_CONSTS
public static class ManagedNameConstants
#else
internal static class ManagedNameConstants /* To linke it inside htmllogger project. */
#endif
{
    /// <summary>
    /// Label to use on ManagedType test property.
    /// </summary>
    public const string ManagedTypeLabel = "ManagedType";

    /// <summary>
    /// Label to use on ManagedMethod test property.
    /// </summary>
    public const string ManagedMethodLabel = "ManagedMethod";

    /// <summary>
    /// Property id to use on ManagedType test property.
    /// </summary>
    public const string ManagedTypePropertyId = "TestCase." + ManagedTypeLabel;

    /// <summary>
    /// Property id to use on ManagedMethod test property.
    /// </summary>
    public const string ManagedMethodPropertyId = "TestCase." + ManagedMethodLabel;
}
