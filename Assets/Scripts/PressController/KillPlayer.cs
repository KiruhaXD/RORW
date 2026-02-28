using TMPro;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] Animator _diedPanelAnimator;
    [SerializeField] GameObject _diedPanel;
    [SerializeField] TMP_Text _diedText;
    
    [SerializeField] WriteTextAfterDied _writeTextAfterDied;
    [SerializeField] MouseSensivity _mouseSensivity;
    [SerializeField] PlayerInteract _playerInteract;

    private void Awake()
    {
        _diedPanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            _mouseSensivity.enabled = false;
            _playerInteract.enabled = false;

            _diedPanel.gameObject.SetActive(true);
            _diedPanelAnimator.SetBool("isOpen", false);
            _diedText.gameObject.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            StartCoroutine(_writeTextAfterDied.TypingText());
        }
            
    }

}
