public class Pawn : Figure
{
    private bool isMoved = false;

    public override bool CanMove(Cell targetPosition)
    {
        if(base.CanMove(targetPosition) == false)
            return false;
        int direction = CurrentPosition.Figure.Color == Chess.Color.White ? 1 : -1;
        int moveCells = isMoved ? 1 : 2 * direction;

        if ((targetPosition.Y == CurrentPosition.Y + direction
            || isMoved == false
            && targetPosition.Y == CurrentPosition.Y + moveCells
            && targetPosition.X == CurrentPosition.X)
            && targetPosition.IsEmpty)
            return true;

        if(targetPosition.Y == CurrentPosition.Y + direction 
            && (targetPosition.X == CurrentPosition.X + 1
            || targetPosition.X == CurrentPosition.X - 1)
            && CurrentPosition.isEnemy(targetPosition))
            return true;

        return false;
    }

    public override void Move(Cell targetPosition)
    {
        base.Move(targetPosition);
        isMoved = true;
    }
}
