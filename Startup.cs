﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(baumann_MIS4200.Startup))]
namespace baumann_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
