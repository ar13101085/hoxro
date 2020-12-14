using Hoxro.HoxroAttribute;
using Hoxro.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using System.Security.Authentication;

namespace Hoxro.Filters
{
    public class AuthorizationFilter : IActionFilter
    {
        public readonly UserManager<ApplicationUser> _userManager;
        public AuthorizationFilter(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            #region Active user checking. Future need to be refactor where synchronus call

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                var applicationUserId = context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
                var applicationUser =  _userManager.FindByIdAsync(applicationUserId).Result;
                if (!(applicationUser.IsActive && applicationUser.IsActive))
                {
                    throw new AuthenticationException("You are not active user or may not have enough permission.");
                }
            }

            #endregion
            

            #region Get Action Role value

            var t = context.Controller.GetType();
            var actionName = ((dynamic) context.ActionDescriptor).ActionName;
            var listAttribute = t.GetMethod(actionName).GetCustomAttributes(typeof(Attribute), true);
            foreach (var attr in listAttribute)
                if (attr is RoleAttribute)
                {
                    var roleAttr = (RoleAttribute) attr;
                    if (!context.HttpContext.User.HasClaim(x => x.Value == roleAttr.UniqueValue))
                        throw new AuthenticationException("You have not enough permission.");
                }

            #endregion
        }


        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Go Executed");
        }
    }
}