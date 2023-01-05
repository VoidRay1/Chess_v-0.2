using UnityEngine;
using Color = Chess.Color;

public abstract class Figure : MonoBehaviour
{
    private Color _color;

    public Cell CurrentPosition;
    public Color Color => _color;

    public Figure Initialize(Cell currentPosition, Color color)
    {
        CurrentPosition = currentPosition;
        _color = color;
        return this;
    }

    public virtual void Move(Cell targetPosition)
    {
        GameObject figure = transform.gameObject;
        transform.parent.DetachChildren();
        if (targetPosition.Figure)
        {
            Destroy(targetPosition.Figure.transform.gameObject);
            targetPosition.Figure = null;
        }
        CurrentPosition.Figure = null;
        CurrentPosition = targetPosition;
        targetPosition.Figure = this;
        figure.transform.SetParent(CurrentPosition.transform);
        figure.transform.localPosition = new Vector3(0, 0, 0);
    }

    public virtual bool CanMove(Cell targetPosition)
    {
        if (targetPosition.Figure?.Color == _color)
            return false;
        if (targetPosition.Figure && targetPosition.Figure is King)
            return false;
        return true;
    }
}
