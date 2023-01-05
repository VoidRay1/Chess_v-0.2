using UnityEngine;
using Color = Chess.Color;

public class Player
{
    private Color _colorSide;

    public Color ColorSide => _colorSide;

    public Player(Color colorSide)
    {
        _colorSide = colorSide;
    }

}
