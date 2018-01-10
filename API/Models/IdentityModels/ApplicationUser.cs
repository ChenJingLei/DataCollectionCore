using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace API.Models.IdentityModels
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        [Display(Name = "姓名")]
        [StringLength(256)]
        public string Name { get; set; }

        public Guid WeChatAccountId { get; set; }

        public virtual WeChatAccount WeChatAccount { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

    }
}
