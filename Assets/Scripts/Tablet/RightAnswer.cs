using UnityEngine;

// Список правильных ответов: 5, 2, 2, 3, 5
public class RightAnswer : Answers
{
    [SerializeField] UpdateText _updateText;
    
    private void Update()
    {
        if (_yesOrNo._textIfYes.gameObject.activeSelf == true) 
        {
            StartCoroutine(_updateText.TimeToHideMessage());

            _cinemachineCameraTV.gameObject.SetActive(true);
            _cinemachineCameraTablet.gameObject.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        _updateText.HideCursor();

        _cinemachineCameraTablet.gameObject.SetActive(false);

        _yesOrNo._textIfNo.gameObject.SetActive(false);

        StartCoroutine(_updateText.TimeToShowMessage());
    }


}
