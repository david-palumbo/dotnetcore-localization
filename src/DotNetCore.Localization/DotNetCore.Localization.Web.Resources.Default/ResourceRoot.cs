using DotNetCore.Localization.Web.Resources.Default.Controllers;

namespace DotNetCore.Localization.Web.Resources.Default
{
    public class ResourceRoot
    {
        private static readonly HomeControllerResource _homeController = new HomeControllerResource();
        public virtual HomeControllerResource HomeController => _homeController;
    }