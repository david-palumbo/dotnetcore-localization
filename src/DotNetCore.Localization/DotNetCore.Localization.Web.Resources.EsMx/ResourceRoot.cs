using DotNetCore.Localization.Web.Resources.Default.Controllers;

namespace DotNetCore.Localization.Web.Resources.EsMx
{
    public class ResourceRoot : Default.ResourceRoot
    {
        public override HomeControllerResource HomeController => new Controllers.HomeControllerResource();
    }
}