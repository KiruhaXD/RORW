using System.Collections;
using Unity.Cinemachine;
using UnityEngine;

public class UpdateText : MonoBehaviour
{
    [SerializeField] public GameObject[] _tmpTextsForQuestions;
    [SerializeField] public GameObject[] _tmpTextForAnswers;

    [SerializeField] CinemachineCamera _cinemachineCameraPlayer;

    [SerializeField] YesOrNo _yesOrNo;
    [SerializeField] PlayerRotate playerRotate;
    [SerializeField] WriteText _writeText;

    private static int activateCount = 0;

    public IEnumerator TimeToShowMessage()
    {
        yield return new WaitForSeconds(3);

        _yesOrNo._textIfYes.gameObject.SetActive(true);
        activateCount++;
        Debug.Log($"Count: {activateCount}");

        _yesOrNo._audioSourceYes.PlayOneShot(_yesOrNo._audioClipYes);

        _cinemachineCameraPlayer.gameObject.SetActive(true);

        playerRotate.RotateYToZero();

        HideCursor();

        ShowNewText();
    }

    public IEnumerator TimeToHideMessage()
    {
        yield return new WaitForSeconds(2);

        _yesOrNo._textIfYes.gameObject.SetActive(false);
    }

    public void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ShowNewText()
    {
        if (activateCount >= 1 && activateCount <= 5)
        {
            int prevIndex = activateCount - 1;
            int nextIndex = activateCount;

            _tmpTextsForQuestions[prevIndex].gameObject.SetActive(false);
            _tmpTextsForQuestions[nextIndex].gameObject.SetActive(true);

            _tmpTextForAnswers[prevIndex].gameObject.SetActive(false);
            _tmpTextForAnswers[nextIndex].gameObject.SetActive(true);

            if (_writeText != null)
            {
                //_writeText.ResetTypingState();
                _writeText.UpdateTextFields();
                _writeText.isTyping = true;
                StartCoroutine(_writeText.TypingText());
            }

        }
    }
}
