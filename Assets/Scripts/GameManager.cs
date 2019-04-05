using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public float restartdelay = 1f;
    public GameObject COMPLETELEVELUI;

    public void Completelevel()
    {
        COMPLETELEVELUI.SetActive(true);

    }
    public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAme Over!!");
            Invoke("Restart", restartdelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}