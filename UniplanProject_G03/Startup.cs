using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System;
using UniplanProject_G03.Models;

[assembly: OwinStartupAttribute(typeof(UniplanProject_G03.Startup))]
namespace UniplanProject_G03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

   }
}
