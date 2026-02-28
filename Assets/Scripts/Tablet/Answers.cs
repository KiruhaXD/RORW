using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour
{
    [SerializeField] Image _imageChoise;

    [SerializeField] protected CinemachineCamera _cinemachineCameraPlayer;
    [SerializeField] protected CinemachineCamera _cinemachineCameraTablet;
    [SerializeField] protected CinemachineCamera _cinemachineCameraTV;

    [SerializeField] protected YesOrNo _yesOrNo;

    [SerializeField] protected PlayerRotate playerRotate;

    [SerializeField] AudioSource _audioSourceChoise;
    [SerializeField] AudioClip _audioClipChoise;

    public void OnMouseEnter() 
    {
        _audioSourceChoise.PlayOneShot(_audioClipChoise);
        _imageChoise.gameObject.SetActive(true);
    } 

    private void OnMouseExit() => _imageChoise.gameObject.SetActive(false);

}
