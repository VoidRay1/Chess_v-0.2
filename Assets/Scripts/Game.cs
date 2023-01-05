using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Board _board;
    [SerializeField] private SelectedFigureDisplayer _figureDisplayer;
    private Figure _selectedFigure;

    private void Start()
    {
        _board.Create();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, float.MaxValue))
            {
                if(hit.collider != null && hit.collider.TryGetComponent(out Cell targetPosition))
                {
                    if(_selectedFigure == null && targetPosition.IsEmpty == false)
                    {
                        _selectedFigure = targetPosition.Figure;
                    }
                    else if(_selectedFigure && _selectedFigure.CanMove(targetPosition))
                    {
                        _selectedFigure.Move(targetPosition);
                        _selectedFigure = null;
                    }
                    else if(_selectedFigure && _selectedFigure.CanMove(targetPosition) == false)
                    {
                        _selectedFigure = targetPosition.Figure;
                    }
                    _figureDisplayer.Display(_selectedFigure); 
                } 
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log(_selectedFigure);
        }
    }
}
