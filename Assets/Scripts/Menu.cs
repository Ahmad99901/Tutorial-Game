using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Reminder Start is already function in Unity
    //So u have to use StartGame instead of Start
    public void StartGame () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
