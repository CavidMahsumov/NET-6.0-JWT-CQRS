using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace NET_6._0__JWT__CQRS.Core.Domain
{
    public class AppUser
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string Password { get; set; }
        public int AppRoleId { get; set; }
        public AppRole AppRole { get; set; }
        public AppUser()
        {
            AppRole = new AppRole();
        }

    }
}
