using UnityEngine;
using DG.Tweening;

public class TweenObject : MonoBehaviour
{
    [SerializeField] protected Transform ObjectTransform;
    [SerializeField] protected LoopType LoopType = LoopType.Yoyo;
    [SerializeField] protected float Duration = 2f;
    [SerializeField] protected int Repeats = -1;
}
