using System.Collections;
using TMPro;
using UnityEngine;

public class WriteText : MonoBehaviour
{
    [SerializeField] public TMP_Text[] textFromTV;
    [SerializeField] float _speedTyping = 0.1f;

    [SerializeField] public AudioSource _audioSource;

    private string[] _fullText;
    public bool isTyping;
    private bool _isCoroutineStopped = false;

    private void Start()
    {
        UpdateTextFields();
    }

    public void UpdateTextFields()
    {
        _fullText = new string[textFromTV.Length];

        for (int i = 0; i < textFromTV.Length; i++)
        {
            if (textFromTV[i] != null && textFromTV[i].gameObject.activeInHierarchy)
            {
                _fullText[i] = textFromTV[i].text;
                textFromTV[i].text = "";
            }
            else
            {
                _fullText[i] = "";
            }
        }
    }

    public IEnumerator TypingText()
    {
        int maxLength = 0;
        foreach (string text in _fullText)
        {
            if (text != null && text.Length > maxLength)
                maxLength = text.Length;
        }

        for (int i = 0; i < maxLength && !_isCoroutineStopped; i++)
        {
            for (int j = 0; j < textFromTV.Length; j++)
            {
                if (j < _fullText.Length && _fullText[j] != null && i < _fullText[j].Length && textFromTV[j] != null)
                {
                    textFromTV[j].text += _fullText[j][i];
                }
            }

            yield return new WaitForSeconds(_speedTyping);
            _audioSource.Play();
        }

        isTyping = false;
        _audioSource.Stop();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTyping)
            {
                _isCoroutineStopped = true;
                StopAllCoroutines();

                for (int i = 0; i < textFromTV.Length; i++)
                {
                    if (textFromTV[i] != null && textFromTV[i].gameObject.activeInHierarchy && i < _fullText.Length)
                        textFromTV[i].text = _fullText[i];
                }

                isTyping = false;
                _audioSource.Stop();
            }
        }

    }

    public void ResetTypingState() 
    {
        StopAllCoroutines();

        isTyping = false;
        _isCoroutineStopped = false;

        if(_audioSource != null)
            _audioSource.Stop();
    }
}
