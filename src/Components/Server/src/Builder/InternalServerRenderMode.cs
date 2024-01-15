// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http.Connections;

namespace Microsoft.AspNetCore.Builder;

internal class InternalServerRenderMode(Action<HttpConnectionDispatcherOptions>? configureOptions = null) : InteractiveServerRenderMode
{
    public Action<HttpConnectionDispatcherOptions>? ConfigureConnectionOptions { get; } = configureOptions;
}
