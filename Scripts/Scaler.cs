using UnityEngine;
using DG.Tweening;

public class Scaler : TweenObject
{
    [SerializeField] private float _scaleTarget = 0.2f;

    private void Start()
    {
        ObjectTransform.DOScale(_scaleTarget, Duration).SetLoops(Repeats, LoopType);
    }
}