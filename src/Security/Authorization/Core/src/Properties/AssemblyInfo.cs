// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Authorization;

// Microsoft.AspNetCore.Http.Abstractions
[assembly: TypeForwardedTo(typeof(IAuthorizeData))]
[assembly: TypeForwardedTo(typeof(IAllowAnonymous))]
