using UnityEngine;
using DG.Tweening;

public class ColorChanger : TweenObject
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _targetColor = new Color(40, 140f, 255f);
    [SerializeField] private Color _defaultColor = new Color(0f, 0f, 0f);

    private void Start()
    {
        _material.DOColor(_targetColor, Duration).SetLoops(Repeats, LoopType);
    }

    private void OnDisable()
    {
        _material.color = _defaultColor;
    }
}
