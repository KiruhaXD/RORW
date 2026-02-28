using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public Transform rotationY;

    public void RotateYToZero() => rotationY.rotation = new Quaternion(0f, 0f, 0f, rotationY.rotation.w);
}
