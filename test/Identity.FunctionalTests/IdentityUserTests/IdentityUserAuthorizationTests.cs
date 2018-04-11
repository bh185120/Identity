﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Identity.DefaultUI.WebSite;
using Xunit.Abstractions;

namespace Microsoft.AspNetCore.Identity.FunctionalTests.IdentityUserTests
{
    public class IdentityUserAuthorizationTests : AuthorizationTests<Startup>
    {
        public IdentityUserAuthorizationTests(ServerFactory<Startup> serverFactory, ITestOutputHelper output) : base(serverFactory, output)
        {
        }
    }
}
