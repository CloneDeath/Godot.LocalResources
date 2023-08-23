namespace Godot.LocalResources {
	public partial class LocalStyleBoxTexture : StyleBoxTexture {
		public LocalStyleBoxTexture() {
			Texture = RelativeResource.Load<Texture2D>(GetType(), $"{GetType().Name}.png");
		}
	}
}