using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public class Config
    {
        // scopes define the resources in your system
        public static IEnumerable<Scope> GetScopes()
        {
            return new List<Scope>
            {
                StandardScopes.OpenId,
                StandardScopes.Profile                
            };
        }


        // client want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {

                new Client
                {
                    ClientId = "ResumeManagerApp",                    
                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequireConsent = false,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    RedirectUris = { "http://localhost:5002/signin-oidc" },
                    PostLogoutRedirectUris = { "http://localhost:5002" },
                    AllowedScopes =
                    {
                        StandardScopes.OpenId.Name,
                        StandardScopes.Profile.Name                        
                    }
                }
            };
        }
    }
}
