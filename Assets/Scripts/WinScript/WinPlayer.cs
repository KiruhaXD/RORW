using TMPro;
using UnityEngine;

public class WinPlayer : MonoBehaviour
{
    [SerializeField] Animator _winPanelAnimator;
    [SerializeField] GameObject _winPanel;
    [SerializeField] TMP_Text _winText;

    [SerializeField] WriteTextAfterWin _writeTextAfterWin;
    [SerializeField] PlayerInteract _playerInteract;
    [SerializeField] MouseSensivity _mouseSensivity;
    [SerializeField] UpdateText _updateText;
    [SerializeField] YesOrNo _yesOrNo;

    [SerializeField] GameObject _writingTextAudio;

    private bool isShow;

    private void Awake()
    {
        _winPanel.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (!isShow && _updateText._tmpTextsForQuestions[5].gameObject.activeSelf == true && _updateText._tmpTextForAnswers[5].gameObject.activeSelf == true && _yesOrNo._textIfYes.gameObject.activeSelf == true) 
        {
            _writingTextAudio.gameObject.SetActive(false);
            _mouseSensivity.enabled = false;
            _playerInteract.enabled = false;

            _winPanel.gameObject.SetActive(true);
            _winPanelAnimator.SetBool("isOpen", false);
            _winText.gameObject.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            StartCoroutine(_writeTextAfterWin.TypingText());

            isShow = true;
        }


    }
}
