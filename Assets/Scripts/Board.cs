using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private Cell _cell;
    [SerializeField] private FigureSpawner _figureSpawner;
    private Cell[,] _cells = new Cell[WIDTH, HEIGHT];
    private const int WIDTH = 8;
    private const int HEIGHT = 8;

    public int Width => WIDTH;
    public int Height => HEIGHT;    
    public Cell[,] Cells => _cells;

    public void Create()
    {
        Color color;
        for (int y = 0; y < HEIGHT; y++)
        {
            for(int x = 0; x < WIDTH; x++)
            {
                var cell = Instantiate(_cell, transform.position + new Vector3Int(x, y, 0), Quaternion.identity, transform);
                color = (x + y) % 2 == 0 ? Color.white : new Color(128, 64, 48);
                cell.GetComponent<Cell>().Init(x, y, this, color);
                cell.GetComponent<Renderer>().material.color = color;
                _cells[y, x] = cell.GetComponent<Cell>();
            }
        }
        _figureSpawner.Spawn();
    }

}
