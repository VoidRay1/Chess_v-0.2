using UnityEngine;

public class FigureSpawner : MonoBehaviour
{
    [SerializeField] private Board _board;
    [SerializeField] private Pawn _whitePawn;
    [SerializeField] private Pawn _blackPawn;
    [SerializeField] private Knight _whiteKnight;
    [SerializeField] private Knight _blackKnight;
    [SerializeField] private Bishop _whiteBishop;
    [SerializeField] private Bishop _blackBishop;
    [SerializeField] private Rook _whiteRook;
    [SerializeField] private Rook _blackRook;
    [SerializeField] private Queen _whiteQueen;
    [SerializeField] private Queen _blackQueen;
    [SerializeField] private King _whiteKing;
    [SerializeField] private King _blackKing;

    public void Spawn()
    {
        SpawnWhiteFigures();
        SpawnBlackFigures();
    }

    private void SpawnWhiteFigures()
    {
        for (int x = 0; x < _board.Width; x++)
        {
            _board.Cells[1, x].Figure = Instantiate(_whitePawn, _board.Cells[1, x].transform.position, Quaternion.identity, _board.Cells[1, x].transform)
                 .Initialize(_board.Cells[1, x], Chess.Color.White);
        }
        _board.Cells[0, 1].Figure = Instantiate(_whiteKnight, _board.Cells[0, 1].transform.position, Quaternion.identity, _board.Cells[0, 1].transform)
            .Initialize(_board.Cells[0, 1], Chess.Color.White);
        _board.Cells[0, 6].Figure = Instantiate(_whiteKnight, _board.Cells[0, 6].transform.position, Quaternion.identity, _board.Cells[0, 6].transform)
            .Initialize(_board.Cells[0, 6], Chess.Color.White); 
        _board.Cells[0, 2].Figure = Instantiate(_whiteBishop, _board.Cells[0, 2].transform.position, Quaternion.identity, _board.Cells[0, 2].transform)
            .Initialize(_board.Cells[0, 2], Chess.Color.White); 
        _board.Cells[0, 5].Figure = Instantiate(_whiteBishop, _board.Cells[0, 5].transform.position, Quaternion.identity, _board.Cells[0, 5].transform)
            .Initialize(_board.Cells[0, 5], Chess.Color.White); 
        _board.Cells[0, 0].Figure = Instantiate(_whiteRook, _board.Cells[0, 0].transform.position, Quaternion.identity, _board.Cells[0, 0].transform)
            .Initialize(_board.Cells[0, 0], Chess.Color.White); 
        _board.Cells[0, 7].Figure = Instantiate(_whiteRook, _board.Cells[0, 7].transform.position, Quaternion.identity, _board.Cells[0, 7].transform)
            .Initialize(_board.Cells[0, 7], Chess.Color.White);
        _board.Cells[0, 3].Figure = Instantiate(_whiteQueen, _board.Cells[0, 3].transform.position, Quaternion.identity, _board.Cells[0, 3].transform)
            .Initialize(_board.Cells[0, 3], Chess.Color.White);
        _board.Cells[0, 4].Figure = Instantiate(_whiteKing, _board.Cells[0, 4].transform.position, Quaternion.identity, _board.Cells[0, 4].transform)
            .Initialize(_board.Cells[0, 4], Chess.Color.White);
    }

    private void SpawnBlackFigures()
    {
        for (int x = 0; x < _board.Width; x++)
        {
            _board.Cells[6, x].Figure = Instantiate(_blackPawn, _board.Cells[6, x].transform.position, Quaternion.identity, _board.Cells[6, x].transform)
                 .Initialize(_board.Cells[6, x], Chess.Color.Black);
        }
        _board.Cells[7, 1].Figure = Instantiate(_blackKnight, _board.Cells[7, 1].transform.position, Quaternion.identity, _board.Cells[7, 1].transform)
             .Initialize(_board.Cells[7, 1], Chess.Color.Black);
        _board.Cells[7, 6].Figure = Instantiate(_blackKnight, _board.Cells[7, 6].transform.position, Quaternion.identity, _board.Cells[7, 6].transform)
             .Initialize(_board.Cells[7, 6], Chess.Color.Black);
        _board.Cells[7, 2].Figure = Instantiate(_blackBishop, _board.Cells[7, 2].transform.position, Quaternion.identity, _board.Cells[7, 2].transform)
             .Initialize(_board.Cells[7, 2], Chess.Color.Black); 
        _board.Cells[7, 5].Figure = Instantiate(_blackBishop, _board.Cells[7, 5].transform.position, Quaternion.identity, _board.Cells[7, 5].transform)
             .Initialize(_board.Cells[7, 5], Chess.Color.Black);
        _board.Cells[7, 0].Figure = Instantiate(_blackRook, _board.Cells[7, 0].transform.position, Quaternion.identity, _board.Cells[7, 0].transform)
             .Initialize(_board.Cells[7, 0], Chess.Color.Black);
        _board.Cells[7, 7].Figure = Instantiate(_blackRook, _board.Cells[7, 7].transform.position, Quaternion.identity, _board.Cells[7, 7].transform)
             .Initialize(_board.Cells[7, 7], Chess.Color.Black);
        _board.Cells[7, 3].Figure = Instantiate(_blackQueen, _board.Cells[7, 3].transform.position, Quaternion.identity, _board.Cells[7, 3].transform)
             .Initialize(_board.Cells[7, 3], Chess.Color.Black);
        _board.Cells[7, 4].Figure = Instantiate(_blackKing, _board.Cells[7, 4].transform.position, Quaternion.identity, _board.Cells[7, 4].transform)
             .Initialize(_board.Cells[7, 4], Chess.Color.Black);
    }
}
