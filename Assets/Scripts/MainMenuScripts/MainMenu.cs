using TMPro;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TMP_Text _tmpText;

    [SerializeField] GameObject _authorCanvas;
    [SerializeField] GameObject _settingCanvas;

    [SerializeField] SwitchCameras _switchCameras;
    [SerializeField] PlayerRotate _playerRotate;
    [SerializeField] WriteText _writeText;
    [SerializeField] TextColors _colors;


    private void Update()
    {
        ExitToMainMenuCamera();

        if (_switchCameras._virtualCameras[1].gameObject.activeSelf == true) 
        {
            _authorCanvas.SetActive(false);
            _settingCanvas.SetActive(false);

            _colors.AlphaColorForTexts();
        }

    }

    public void ExitToMainMenuCamera() 
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _switchCameras._virtualCameras[1].gameObject.activeSelf == false) 
        {
            _switchCameras._virtualCameras[0].gameObject.SetActive(true);
            _switchCameras._virtualCameras[2].gameObject.SetActive(false);
            _switchCameras._virtualCameras[3].gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        switch (_tmpText.name) 
        {
            case "Text (START_GAME)":
                _switchCameras._virtualCameras[1].gameObject.SetActive(true);
                _switchCameras._virtualCameras[0].gameObject.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                _playerRotate.RotateYToZero();

                _writeText.isTyping = true;
                StartCoroutine(_writeText.TypingText());

                break;

            case "Text (SETTINGS)":
                _switchCameras._virtualCameras[0].gameObject.SetActive(false);
                _switchCameras._virtualCameras[2].gameObject.SetActive(true);
                break;

            case "Text (AUTHOR)":
                Debug.Log("Переход к автору");
                _switchCameras._virtualCameras[0].gameObject.SetActive(false);
                _switchCameras._virtualCameras[3].gameObject.SetActive(true);
                break;

            case "Text (EXIT_GAME)":
                Debug.Log("Выход из игры");
                Application.Quit();
                break;

        }
    }
}
