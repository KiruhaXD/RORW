using Unity.Cinemachine;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public CinemachineCamera[] _virtualCameras;
    private int _currentCameraIndex;

    public void SwitchCinemachineCamera() 
    {
        _virtualCameras[_currentCameraIndex].gameObject.SetActive(false);
        _currentCameraIndex++;

        if (_currentCameraIndex >= _virtualCameras.Length) 
        {
            _currentCameraIndex = 0;
        }

        _virtualCameras[_currentCameraIndex].gameObject.SetActive(true);
    }
}
