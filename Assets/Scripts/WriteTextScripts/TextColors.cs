using TMPro;
using UnityEngine;

public class TextColors : MonoBehaviour
{

    [SerializeField] TMP_Text[] _textColors;

    public void AlphaColorForTexts() 
    {
        foreach (TMP_Text color in _textColors)
        {
            color.color = new Color(38f, 226f, 13f, 0f);
        }
    }
}
