using Domain.Attributes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	[Auditable]
	public class User : IdentityUser 
	{
        public override string Email { get; set; } = null;
        public string FullName { get; set; }

	}
}
