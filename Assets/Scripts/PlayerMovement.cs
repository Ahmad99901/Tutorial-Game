using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Reference to Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 3000f;
    public float sidewaysForce = 500f;
    public float backwardForce = 1000f;
    public float jumpForce = 6;

   
    // Update is called once per frame also fixedupdate cause we messing with physics

    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Move the player forward

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0,7,0), ForceMode.Impulse);
        }

        if (rb.position.y < -1f)
        {

        FindObjectOfType<GameManager>().EndGame();

        }
    }
}
