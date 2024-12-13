using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private string _textNew = "NEW text";
    [SerializeField] private string _textAdded = ". Adding text..";
    [SerializeField] private string _textScramble = "Totally new text";
    [SerializeField] private float _addedTextDelay = 3f;
    [SerializeField] private float _scrambleTextDelay = 6f;

    void Start()
    {
        _text.DOText(_textNew, _duration);
        _text.DOText(_textAdded, _duration).SetRelative().SetDelay(_addedTextDelay);
        _text.DOText(_textScramble, _duration, true, ScrambleMode.All).
                                                        SetDelay(_scrambleTextDelay);
    }
}
