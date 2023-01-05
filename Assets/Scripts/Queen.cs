using UnityEngine;

public class Queen : Figure
{
    public override bool CanMove(Cell targetPosition)
    {
        if (base.CanMove(targetPosition) == false)
            return false;
        if(CurrentPosition.IsEmptyHorizontal(targetPosition))
            return true;
        if (CurrentPosition.IsEmptyVertical(targetPosition))
            return true;
        if (CurrentPosition.IsEmptyDiagonal(targetPosition))
            return true;
        return false;
    }
}
