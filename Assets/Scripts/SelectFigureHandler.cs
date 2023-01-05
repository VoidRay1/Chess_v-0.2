using TMPro;
using UnityEngine;

public class SelectFigureHandler : MonoBehaviour
{
    [SerializeField] private SelectedFigureDisplayer _figureDisplayer;
    private Figure _selectedFigure;

    public Figure SelectedFigure => _selectedFigure;

    public bool TrySelect(Player currentPlayer)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, float.MaxValue))
        {
            if (hit.collider != null && hit.collider.TryGetComponent(out Cell targetPosition))
            {
                if (targetPosition.IsEmpty == false 
                    && currentPlayer.ColorSide == targetPosition.Figure.Color)
                {
                    _selectedFigure = targetPosition.Figure;
                    _figureDisplayer.Display(_selectedFigure);
                    return true;
                }
            }
        }
        return false;
    }
    public bool TryMove()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, float.MaxValue))
        {
            if (hit.collider != null && hit.collider.TryGetComponent(out Cell targetPosition))
            {
                if(_selectedFigure && _selectedFigure.CanMove(targetPosition))
                {
                    _selectedFigure.Move(targetPosition);
                    _selectedFigure = null;
                    _figureDisplayer.Display(_selectedFigure);
                    return true;
                }
            }
        }
        return false;
    }
   
}
