using UnityEngine;

public class RestartForDead : RestartButton
{
    [SerializeField] WriteTextAfterDied _writeTextAfterDied;

    private void Update()
    {
        if (_writeTextAfterDied._textAfterDied.text == _writeTextAfterDied._fullText)
            StartCoroutine(ShowButtonRestart());
    }
}
