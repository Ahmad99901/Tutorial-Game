using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    
    public PlayerMovement movement; // Reference to PlayerMovement Script
    
    //Function runs when we hit another object
    //Info about collision and call it "collisionInfo"
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //Disable the players movement
            FindObjectOfType<GameManager>().EndGame();
            audioManager.PlaySFX(audioManager.wallTouch);
            
        }
    }

}
