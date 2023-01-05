public class Rook : Figure
{
    public override bool CanMove(Cell targetPosition)
    {
        if (base.CanMove(targetPosition) == false)
            return false;
        if (CurrentPosition.IsEmptyHorizontal(targetPosition))
            return true;
        if (CurrentPosition.IsEmptyVertical(targetPosition))
            return true;
        return false;
    }
}
