using Unity.Cinemachine;
using UnityEngine;

public class ExitFromTablet : MonoBehaviour
{
    [SerializeField] CinemachineCamera _cinemachineCameraPlayer;

    [SerializeField] InteractWithTablet _interactWithTablet;

    private void Update()
    {
        Exit();
    }

    public void Exit()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _interactWithTablet.isInteract == true)
        {
            _cinemachineCameraPlayer.gameObject.SetActive(true);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            _interactWithTablet.isInteract = false;
        }
    }
}
