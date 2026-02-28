using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] Animator _animatorPausePanel;

    [SerializeField] GameObject _buttonRestart;
    [SerializeField] GameObject _textPause;

    [SerializeField] SwitchCameras _switchCameras;
    [SerializeField] MouseSensivity _mouseSensivity;
    [SerializeField] PlayerInteract _playerInteract;

    int _keyPressEsc = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _switchCameras._virtualCameras[1].gameObject.activeSelf == true) 
        {
            switch (_keyPressEsc)
            {
                case 0:
                    _animatorPausePanel.SetBool("isOpen", true);
                    _textPause.SetActive(true);
                    _buttonRestart.SetActive(true);

                    _mouseSensivity.enabled = false;
                    _playerInteract.enabled = false;

                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;

                    _keyPressEsc = 1;
                    break;

                case 1:
                    _animatorPausePanel.SetBool("isOpen", false);
                    _textPause.SetActive(false);
                    _buttonRestart.SetActive(false);

                    _mouseSensivity.enabled = true;
                    _playerInteract.enabled = true;

                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;

                    _keyPressEsc = 0;
                    break;
            }
        }
    }

    public void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
