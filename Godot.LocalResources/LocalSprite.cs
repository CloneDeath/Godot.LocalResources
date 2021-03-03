namespace Godot.LocalResources {
	public abstract class LocalSprite : Sprite {
		protected LocalSprite() {
			Name = GetType().Name;
			Texture = RelativeResource.Load<Texture>(GetType(), $"{GetType().Name}.png");
		}
	}
}