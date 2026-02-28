using UnityEngine;
using UnityEngine.UI;


public class ChoiseButton : MonoBehaviour
{
    [SerializeField] Image _imageChoise;
    [SerializeField] AudioSource _audioSourceChoise;
    [SerializeField] AudioClip _audioClipChoise;

    public void OnMouseEnter() 
    {
        _imageChoise.gameObject.SetActive(true);
        _audioSourceChoise.PlayOneShot(_audioClipChoise);
    } 

    private void OnMouseExit() => _imageChoise.gameObject.SetActive(false);
}
