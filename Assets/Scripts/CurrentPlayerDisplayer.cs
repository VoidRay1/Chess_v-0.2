using UnityEngine;
using TMPro;

public class CurrentPlayerDisplayer : MonoBehaviour
{
    [SerializeField] private TMP_Text _currentPlayer;

    public void Display(Player currentPlayer)
    {
        _currentPlayer.text = $"Current player: {currentPlayer.ColorSide}";
    }
}
