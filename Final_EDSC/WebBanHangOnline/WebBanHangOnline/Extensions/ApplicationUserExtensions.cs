using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebBanHangOnline.Models;
using WebBanHangOnline.Models.ViewModels;

namespace WebBanHangOnline.Extensions
{
    public static class ApplicationUserExtensions
    {
        public static UserViewModel ToUserViewModel(this ApplicationUser user, IList<string> roleNames)
        {
            return new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FullName = user.FullName,
                RoleNames = roleNames
            };
        }
    }
}