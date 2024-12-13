using UnityEngine;
using DG.Tweening;

public class Rotator : TweenObject
{
    [SerializeField] private Vector3 _rotateTarget = new Vector3(0f, 180f, 0f);
    [SerializeField] private RotateMode _rotateMode = RotateMode.Fast;

    private void Start()
    {
        ObjectTransform.DORotate(_rotateTarget, Duration, _rotateMode).SetLoops(Repeats, LoopType);
    }
}
