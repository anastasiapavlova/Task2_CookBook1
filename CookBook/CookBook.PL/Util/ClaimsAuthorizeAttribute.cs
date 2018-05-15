using System;
using System.Web;
using System.Web.Mvc;
using CookBook.BLL.Enums;
using System.Security.Claims;

namespace CookBook.PL.Util
{
    public class ClaimsAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            ClaimsIdentity claimsIdentity;
            if (!httpContext.User.Identity.IsAuthenticated)
                return false;

            claimsIdentity = httpContext.User.Identity as ClaimsIdentity;
            var userRole = (AccountTypes)Enum.Parse(typeof(AccountTypes), claimsIdentity.FindFirst(ClaimTypes.Role).Value);
            if (userRole == AccountTypes.Admin)
            {
                return true;
            }
            else
            {
                return false;
            }
            return base.AuthorizeCore(httpContext);
        }
    }
}