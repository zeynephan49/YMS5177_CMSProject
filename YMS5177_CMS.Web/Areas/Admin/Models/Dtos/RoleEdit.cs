using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using YMS5177_CMS.Entity.Entities.Concrete;

namespace YMS5177_CMS.Web.Areas.Admin.Models.Dtos
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> HasRole { get; set; }
        public IEnumerable<AppUser> HasNotRole { get; set; }

        public string RoleName { get; set; }

        public string[] AddIds { get; set; }
        public string[] DeleteIds { get; set; }
    }
}
