using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace EasyNote.Helpers
{
    public static class IdentityHelpers
    {
        public static string GetDisplayName(this IIdentity identity)
        {
            return ((ClaimsIdentity)identity).FindFirst("DisplayName")?.Value;
        }
    }
}