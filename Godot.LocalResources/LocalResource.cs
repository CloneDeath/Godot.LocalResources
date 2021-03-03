namespace Godot.LocalResources {
	public static class LocalResource<TLocal> {
		public static TResource Load<TResource>(string resourceName)
				where TResource : class {
			return RelativeResource.Load<TResource>(typeof(TLocal), resourceName);
		}
		
		public static string GetResourcePath(string resourceName) {
			return RelativeResource.GetResourcePath(typeof(TLocal), resourceName);
		}
	}
}