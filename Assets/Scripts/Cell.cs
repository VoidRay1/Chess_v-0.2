using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[RequireComponent(typeof(Renderer))]
public class Cell : MonoBehaviour
{
    // serialize for debug
    [SerializeField] private int _x;
    [SerializeField] private int _y;
    [SerializeField] private Color _color;
    private Board _board;

    public Figure Figure;
    public int X => _x;
    public int Y => _y;
    public bool IsEmpty => Figure == null;

    public void Init(int x, int y, Board board, Color color)
    {
        _x = x;
        _y = y;
        _board = board;
        _color = color;
    }

    public bool isEnemy(Cell targetPosition)
    {
        if (targetPosition?.Figure)
            return Figure?.Color != targetPosition.Figure.Color;
        return false;
    }

    public bool IsEmptyHorizontal(Cell targetPosition)
    {
        if (_y != targetPosition.Y)
            return false;
        int min = Mathf.Min(_x, targetPosition.X);
        int max = Mathf.Max(_x, targetPosition.X);
        for (int x = min + 1; x < max; x++)
            if (_board.Cells[_y, x].IsEmpty == false)
                return false;
        return true;
    }

    public bool IsEmptyVertical(Cell targetPosition)
    {
        if (_x != targetPosition.X)
            return false;
        int min = Mathf.Min(_y, targetPosition.Y);
        int max = Mathf.Max(_y, targetPosition.Y);
        for (int y = min + 1; y < max; y++)
            if (_board.Cells[y, _x].IsEmpty == false)
                return false;
        return true;
    }
    public bool IsEmptyDiagonal(Cell targetPosition) 
    {
        int xDiff = Mathf.Abs(targetPosition.X - _x);
        int yDiff = Mathf.Abs(targetPosition.Y - _y);
        if(xDiff != yDiff)
            return false;
        int dx = _x < targetPosition.X ? 1 : -1;
        int dy = _y < targetPosition.Y ? 1 : -1;
        for (int i = 1; i < yDiff; i++) 
            if(_board.Cells[_y + dy * i, _x + dx * i].IsEmpty == false)
                return false;
        return true;
    }

    public bool IsEmptySquare(Cell targetPosition)
    {
        int minX = Mathf.Min(_x, _x - 1); 
        int maxX = Mathf.Max(_x, _x + 1); 
        int minY = Mathf.Min(_y, _y - 1);
        int maxY = Mathf.Max(_y, _y + 1); 
        if (targetPosition.X > maxX || targetPosition.X < minX)
            return false;
        if (targetPosition.Y > maxY || targetPosition.Y < minY)
            return false;
        if (_board.Cells[targetPosition.Y, targetPosition.X].IsEmpty == false)
            return true;
        return true;
    }
}

