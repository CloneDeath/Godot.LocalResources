namespace Godot.LocalResources {
	public abstract partial class LocalSprite : Sprite2D {
		protected LocalSprite() {
			Name = GetType().Name;
			Texture = RelativeResource.Load<Texture2D>(GetType(), $"{GetType().Name}.png");
		}
	}
}