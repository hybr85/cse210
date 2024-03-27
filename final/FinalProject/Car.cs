using System.Numerics;
using Microsoft.Xna.Framework.Graphics;

abstract class Car
{
    private string make;
    private string model;
    private int hp;
    private Vector2 position;
    int gears;
    string color;

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        spriteBatch.Begin(samplerState: SamplerState.PointClamp);
        spriteBatch.Draw(tex, new Rectangle(new Point(0, 0), new Point(385, 175)), null, Color.White);
        spriteBatch.End();
        base.Draw(gameTime);
    }

    abstract public void Display(SpriteBatch spriteBatch, Texture2D ballTexture);
}