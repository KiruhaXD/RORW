using UnityEngine;
using System.Collections;
using TMPro;

public class WriteTextAfterDied : MonoBehaviour
{
    [SerializeField] GameObject _diedPanel;

    [SerializeField] public TMP_Text _textAfterDied;
    [SerializeField] float _speedTyping = 0.05f;

    public string _fullText;
    private bool _isTyping;
    private bool _isCoroutineStopped = false;

    private void Start()
    {
        _fullText = _textAfterDied.text;
        _textAfterDied.text = "";
    }

    public IEnumerator TypingText()
    {
        for (int i = 0; i < _fullText.Length && !_isCoroutineStopped; i++)
        {
            _textAfterDied.text += _fullText[i];
            yield return new WaitForSeconds(_speedTyping);
        }

        _isTyping = false;
    }
}
