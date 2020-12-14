using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace Hoxro.Models
{
    public class ApplicationUser : IdentityUser
    {

        public bool IsActive { get; set; }
    }

}