using System.Collections;
using UnityEngine;

public class Press : MonoBehaviour
{
    [SerializeField] Transform _player;

    [SerializeField] float _speed = 2f;

    [SerializeField] YesOrNo _yesOrNo;

    private void Update()
    {
        if (_yesOrNo._textIfNo.gameObject.activeSelf == true)
            StartCoroutine(StartMovePress());
    }

    IEnumerator StartMovePress() 
    {
        yield return new WaitForSeconds(2);
        transform.position = Vector3.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);
    }
}
