using UnityEngine;

public class RestartForWin : RestartButton
{
    [SerializeField] WriteTextAfterWin _writeTextAfterWin;

    private void Update()
    {
        if (_writeTextAfterWin._textAfterWin.text == _writeTextAfterWin._fullText)
            StartCoroutine(ShowButtonRestart());
    }
}
