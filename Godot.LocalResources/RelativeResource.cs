using System;
using System.Linq;

namespace Godot.LocalResources {
	public static class RelativeResource {
		public static TResource Load<TResource>(Type localType, string resourceName)
			where TResource : class {
			var resourcePath = GetResourcePath(localType, resourceName);
			return ResourceLoader.Load<TResource>(resourcePath);
		}

		public static string GetBasePath(Type localType) {
			var namespaces = localType.Namespace?.Split('.');
			var pathParts = namespaces?.Skip(1) ?? Array.Empty<string>();
			var path = string.Join("/", pathParts);
			return $"res://{path}";
		}

		public static string GetResourcePath(Type localType, string resourceName) {
			return System.IO.Path.Combine(GetBasePath(localType), resourceName);
		}
	}
}