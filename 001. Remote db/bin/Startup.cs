
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Remote_db.Startup))]


namespace Remote_db {
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
