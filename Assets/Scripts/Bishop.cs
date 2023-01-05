public class Bishop : Figure
{
    public override bool CanMove(Cell targetPosition)
    {
        if (base.CanMove(targetPosition) == false)
            return false;
        if (CurrentPosition.IsEmptyDiagonal(targetPosition))
            return true;
        return false;
    }
}
