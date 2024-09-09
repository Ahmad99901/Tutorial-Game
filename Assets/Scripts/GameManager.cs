using UnityEngine;
using UnityEngine.SceneManagement; 

//SceneMangement for whenever we need to restart or reload scene

public class GameManager : MonoBehaviour

{

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    
    {
    
        completeLevelUI.SetActive(true);
        audioManager.PlaySFX(audioManager.checkpoint);

    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);
        }
    }
    void Restart () 
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

}

// SceneManager.LoadScene (Loads the Scene) and after that part it gives the name of the scene