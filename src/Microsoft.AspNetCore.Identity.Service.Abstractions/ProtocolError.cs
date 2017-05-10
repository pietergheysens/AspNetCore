﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Microsoft.AspNetCore.Identity.Service
{
    public class AuthorizationRequestError
    {
        public AuthorizationRequestError(OpenIdConnectMessage error, string redirectUri, string responseMode)
        {
            Message = error;
            RedirectUri = redirectUri;
            ResponseMode = responseMode;
        }

        public OpenIdConnectMessage Message { get; set; }

        public string RedirectUri { get; set; }

        public string ResponseMode { get; set; }
    }
}
