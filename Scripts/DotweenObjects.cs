using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DotweenObjects : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField] private Transform _sphere;
    [SerializeField] private Transform _cube;
    [SerializeField] private Transform _capsule;
    [SerializeField] private Transform _cube2;
    [SerializeField] private Material _sphere2;
    [SerializeField] private Text _text;

    [Header("Target settings")]
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private Vector3 _sphereMoveTarget = new Vector3(-6f, 5f, 0f);
    [SerializeField] private Vector3 _cube2MoveTarget = new Vector3(3f, 5f, 0f);
    [SerializeField] private Vector3 _rotateTarget = new Vector3(0f, 180f, 0f);
    [SerializeField] private RotateMode _rotateMode = RotateMode.Fast;
    [SerializeField] private Color _colorTarget = new Color(100f, 0f, 0f);
    [SerializeField] private float _scaleTarget = 0.5f;

    [Header("Text target")]
    [SerializeField] private string _textNew = "NEW text";
    [SerializeField] private string _textAdded = ". Adding text..";
    [SerializeField] private string _textScramble = "Totally new text";
    [SerializeField] private float _textDelay = 3f;

    private Color _color = new Color(0f, 0f, 0f);

    private void Start()
    {
        _sphere.DOMove(_sphereMoveTarget, _duration, false).SetLoops(_repeats, _loopType);

        _cube.DORotate(_rotateTarget, _duration, _rotateMode).SetLoops(_repeats, _loopType);

        _capsule.DOScale(_scaleTarget, _duration).SetLoops(_repeats, _loopType);

        _cube2.DOMove(_cube2MoveTarget, _duration, false).SetLoops(_repeats, _loopType);
        _cube2.DORotate(_rotateTarget, _duration, _rotateMode).SetLoops(_repeats, _loopType);
        _cube2.DOScale(_scaleTarget, _duration).SetLoops(_repeats, _loopType);

        _sphere2.DOColor(_colorTarget, _duration).SetLoops(_repeats, _loopType);

        _text.DOText(_textNew, _duration);
        _text.DOText(_textAdded, _duration).SetRelative().SetDelay(_textDelay);
        _text.DOText(_textScramble, _duration, true, ScrambleMode.All).SetDelay(_textDelay * 2);
    }

    private void OnDisable()
    {
        _sphere2.color = _color;
    }
}
