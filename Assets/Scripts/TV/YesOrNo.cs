using TMPro;
using UnityEngine;

public class YesOrNo : MonoBehaviour
{
    [SerializeField] public TMP_Text _textIfYes, _textIfNo;

    [SerializeField] public AudioSource _audioSourceYes, _audioSourceNo;
    [SerializeField] public AudioClip _audioClipYes, _audioClipNo;
}
