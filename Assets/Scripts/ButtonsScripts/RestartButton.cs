using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    [SerializeField] GameObject _buttonRestart;

    public void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    protected IEnumerator ShowButtonRestart() 
    {
        yield return new WaitForSeconds(2f);
        _buttonRestart.SetActive(true);
    }
}
