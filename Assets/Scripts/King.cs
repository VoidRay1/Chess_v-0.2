public class King : Figure
{
    public override bool CanMove(Cell targetPosition)
    {
        if (base.CanMove(targetPosition) == false)
            return false;
        if (CurrentPosition.IsEmptySquare(targetPosition) == false)
            return false;
        return true;
    }
}
