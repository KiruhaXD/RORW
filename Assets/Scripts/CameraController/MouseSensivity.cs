using UnityEngine;
using UnityEngine.InputSystem;

public class MouseSensivity : MonoBehaviour
{
    [SerializeField] Transform _playerBody;

    [SerializeField] float _sensivity = 400f;

    private float _xRotation = 0f;

    private void LateUpdate()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * _sensivity * Time.smoothDeltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _sensivity * Time.smoothDeltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -60f, 60f);

        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        _playerBody.Rotate(Vector3.up * mouseX);
    }
}
