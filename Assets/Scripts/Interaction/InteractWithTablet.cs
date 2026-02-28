using Unity.Cinemachine;
using UnityEngine;

public class InteractWithTablet : MonoBehaviour, IInteraction
{
    [SerializeField] SwitchCameras _cinemachineCamera;

    [SerializeField] PlayerInteract _playerInteract;

    public bool isInteract = false;

    private int _keyPressE = 0;

    public void Interact() 
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            _keyPressE = 1;

            if (_keyPressE == 1)
            {
                SwitchingTablet();
                _keyPressE = 0;
            }
        }
    }

    public void SwitchingTablet() 
    {
        _playerInteract.interactionUI.gameObject.SetActive(false);

        _cinemachineCamera._virtualCameras[0].gameObject.SetActive(false);
        _cinemachineCamera._virtualCameras[1].gameObject.SetActive(false);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        isInteract = true;
    }
}
