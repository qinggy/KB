﻿using KB.Infrastructure.Runtime.Security;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace KB.WebApi.Core
{
    public static class FakeClaimsIdentity
    {
        public static ClaimsIdentity CreateIdentity()
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(DefaultAuthenticationTypes.ApplicationCookie, ClaimTypes.NameIdentifier, ClaimTypes.Role);

            claimsIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, "1"));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, "test"));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Email, "abc@123.com"));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "developer"));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "special user"));
            claimsIdentity.AddClaim(new Claim(Comm100ClaimTypes.SideId, "10000"));

            return claimsIdentity;
        }
    }
}