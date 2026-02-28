using System.Collections;
using UnityEngine;

public class ChoosingAnswer : Answers
{
    private void OnMouseDown()
    {
        HideCursor();

        _cinemachineCameraTablet.gameObject.SetActive(false);

        _yesOrNo._textIfYes.gameObject.SetActive(false);

        StartCoroutine(TimeToShowMessage());
    }

    IEnumerator TimeToShowMessage()
    {
        yield return new WaitForSeconds(3);

        _yesOrNo._textIfNo.gameObject.SetActive(true);

        _yesOrNo._audioSourceNo.PlayOneShot(_yesOrNo._audioClipNo);

        _cinemachineCameraPlayer.gameObject.SetActive(true);

        playerRotate.RotateYToZero();

        HideCursor();
    }

    public void HideCursor() 
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
