using System.Numerics;
using Microsoft.Xna.Framework.Graphics;

abstract class Car {
    private string make;
    private string model;
    private int hp;
    private Vector2 position;
    int gears;
    string color;

    abstract public void Display(SpriteBatch spriteBatch, Texture2D ballTexture);
}