using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    // OnTriggerEnter is called when another Collider enters the trigger.
    void OnTriggerEnter()
    {
            // Call the CompletedLevel method in the gameManager.
        gameManager.CompleteLevel();

    }
}



