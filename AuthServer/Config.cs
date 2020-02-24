// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.Collections.Generic;
using IdentityServer4.Models;

namespace Ids4WithAspNetIdentity
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<ApiResource> GetApis()
        {
            return new ApiResource[]
            {
                new ApiResource("api1", "My API #1")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                // client credentials flow client
                new Client
                {
                    ClientId = "client",
                    ClientName = "Client Credentials Client",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },

                    AllowedScopes = { "api1" }
                },

                // MVC client using hybrid flow
                new Client
                {
                    ClientId = "mvc",
                    ClientName = "MVC Client",

                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    RedirectUris = { "http://localhost:5001/signin-oidc" },
                    FrontChannelLogoutUri = "http://localhost:5001/signout-oidc",
                    PostLogoutRedirectUris = { "http://localhost:5001/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "api1" }
                },

                // SPA client using code flow + pkce
                new Client
                {
                    ClientId = "xcportal-dev",
                    ClientName = "xCloud Portal",
                    ClientUri = "http://localhost:4200",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequirePkce = true,
                    RequireClientSecret = false,

                    RedirectUris =
                    {
                        "http://localhost:4200/welcome",
                        "http://localhost:4200/assets/silent-redirect.html",
                    },

                    PostLogoutRedirectUris = { "http://localhost:4200/welcome" },
                    AllowedCorsOrigins = { "http://localhost:4200" },

                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "profile"
                    },
                    AllowAccessTokensViaBrowser = true,
                }
            };
        }
    }
}