using UnityEngine;
using DG.Tweening;

public class Mover : TweenObject
{
    [SerializeField] private Vector3 _moveTarget = new Vector3(-6f, 5f, 0f);

    private void Start()
    {
        ObjectTransform.DOMove(_moveTarget, Duration, false).SetLoops(Repeats, LoopType);
    }
}
