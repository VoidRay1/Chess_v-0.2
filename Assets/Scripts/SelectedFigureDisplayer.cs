using UnityEngine;
using TMPro;

public class SelectedFigureDisplayer : MonoBehaviour
{
    [SerializeField] private TMP_Text _currentFigure;

    public void Display(Figure figure)
    {
        if (figure)
            _currentFigure.text = $"Selected figure: {figure.Color} {figure.GetType().Name}";
        else
            _currentFigure.text = "No selected figure";
    }
}
