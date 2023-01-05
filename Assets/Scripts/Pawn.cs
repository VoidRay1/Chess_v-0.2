public class Pawn : Figure
{
    private bool isMoved = true;

    public override bool CanMove(Cell targetPosition)
    {
        return false;
    }
}
