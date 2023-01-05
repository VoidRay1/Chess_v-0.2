using UnityEngine;

public class Knight : Figure
{
    public override bool CanMove(Cell targetPosition)
    {
        if (base.CanMove(targetPosition) == false)
            return false;
        int diagonalX = Mathf.Abs(CurrentPosition.X - targetPosition.X);
        int diagonalY = Mathf.Abs(CurrentPosition.Y - targetPosition.Y);
        return (diagonalX == 1 && diagonalY == 2) || (diagonalX == 2 && diagonalY == 1);

    }
}
