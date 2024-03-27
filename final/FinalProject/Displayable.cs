using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Displayable
{
    private SpriteBatch spriteBatch;
    private Texture2D tex;
    private int w;
    private int h;
    private Vector2 pos;
    private Rectangle rect;

    public void Display()
    {
        spriteBatch.Draw(tex, rect, null, Color.White);
    }
}