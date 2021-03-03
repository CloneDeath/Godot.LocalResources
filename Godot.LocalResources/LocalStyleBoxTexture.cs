namespace Godot.LocalResources {
	public class LocalStyleBoxTexture : StyleBoxTexture {
		public LocalStyleBoxTexture() {
			Texture = RelativeResource.Load<Texture>(GetType(), $"{GetType().Name}.png");
		}
	}
}