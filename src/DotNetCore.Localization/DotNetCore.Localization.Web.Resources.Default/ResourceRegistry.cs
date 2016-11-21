using System.Collections.Generic;
using System.Reflection;

namespace DotNetCore.Localization.Web.Resources.Default
{
    public class ResourceRegistry
    {
        private ResourceRegistry()
        {
            _registry = new Dictionary<string, ResourceRoot> {{"en-US", new ResourceRoot()}};
        }

        public static ResourceRegistry Instance { get; } = new ResourceRegistry();

        public void RegisterResourceRoot(string name, ResourceRoot root)
        {
            _registry.Add(name, root);
        }

        public ResourceRoot Get(string name)
        {
            return _registry[name];
        }

        private readonly Dictionary<string, ResourceRoot> _registry;
    }
}