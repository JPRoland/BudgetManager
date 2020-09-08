using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Account> UserAccounts { get; set; }
    }
}
