using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    public void ReturnToMenu ()
    {
        SceneManager.LoadScene("Menu");
    }
}
