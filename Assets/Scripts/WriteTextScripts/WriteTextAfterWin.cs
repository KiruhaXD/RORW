using TMPro;
using UnityEngine;
using System.Collections;

public class WriteTextAfterWin : MonoBehaviour
{
    [SerializeField] GameObject _winPanel;

    [SerializeField] public TMP_Text _textAfterWin;
    [SerializeField] float _speedTyping = 0.05f;

    public string _fullText;
    private bool _isTyping;
    private bool _isCoroutineStopped = false;

    private void Start()
    {
        _fullText = _textAfterWin.text;
        _textAfterWin.text = "";
    }

    public IEnumerator TypingText()
    {
        for (int i = 0; i < _fullText.Length && !_isCoroutineStopped; i++)
        {
            _textAfterWin.text += _fullText[i];
            yield return new WaitForSeconds(_speedTyping);
        }

        _isTyping = false;
    }
}
