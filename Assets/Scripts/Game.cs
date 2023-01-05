using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Board _board;
    [SerializeField] private SelectFigureHandler _selectFigureHandler;
    [SerializeField] private CurrentPlayerDisplayer _playerDisplayer;
    private Player[] _players = new Player[2];
    private Player _currentPlayerTurn;
    private Figure _selectedFigure;

    private void Start()
    {
        _board.Create();
        _players[0] = new Player(Chess.Color.White);
        _players[1] = new Player(Chess.Color.Black);
        _currentPlayerTurn = _players[0];
        _playerDisplayer.Display(_currentPlayerTurn);
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (_selectFigureHandler.TrySelect(_currentPlayerTurn))
            {
                _selectedFigure = _selectFigureHandler.SelectedFigure;
            }
            if (_selectedFigure && _selectFigureHandler.TryMove())
            {
                SwitchTurn();
                _playerDisplayer.Display(_currentPlayerTurn);
            }
        }
    }

    private void SwitchTurn()
    {
        if (_players[_players.Length - 1] == _currentPlayerTurn)
            _currentPlayerTurn = _players[0];
        else
            _currentPlayerTurn = _players[_players.Length - 1];
    }
}
