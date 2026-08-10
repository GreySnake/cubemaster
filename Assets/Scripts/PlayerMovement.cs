using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
     public Joystick joystick;
    public Rigidbody rb;
    public float inFata = 20f;
    public float inDreapta = 20f;
    public float inSpate = -5f;
    public float inStanga = -20f;

    public float saritura = 20f;
    // public Player player;
    void FixedUpdate() {
       //rb.velocity = new Vector3(joystick.Horizontal * 50f, rb.velocity.y, 20f);
       float horizontalMove = joystick.Horizontal;
       float verticalMove = joystick.Vertical;
       //joystick.enabled = false;
       //joystickReal.SetActive(false);
       rb.AddForce(0, 0, 18f);
       if(horizontalMove >= 0.05f) {
           rb.AddForce(0.05f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove >= 0.1f) {
           rb.AddForce(0.1f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove >= 0.15f) {
           rb.AddForce(0.15f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove >= 0.2f) {
           rb.AddForce(0.2f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove >= 0.25f) {
           rb.AddForce(0.25f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove >= 0.3f) {
           rb.AddForce(0.3f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove >= 0.35f) {
           rb.AddForce(0.35f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove >= 0.4f) {
           rb.AddForce(0.4f, 0, 0, ForceMode.VelocityChange);
       }


       if(horizontalMove <= -0.05f) {
           rb.AddForce(-0.05f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove <= -0.1f) {
           rb.AddForce(-0.1f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove <= -0.15f) {
           rb.AddForce(-0.15f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove <= -0.2f) {
           rb.AddForce(-0.2f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove <= -0.25f) {
           rb.AddForce(-0.25f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove <= -0.3f) {
           rb.AddForce(-0.3f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove <= -0.35f) {
           rb.AddForce(-0.35f, 0, 0, ForceMode.VelocityChange);
       }
       if(horizontalMove <= -0.4f) {
           rb.AddForce(-0.4f, 0, 0, ForceMode.VelocityChange);
       }

       if(verticalMove <= -0.05f) {
           rb.AddForce(0, 0, -0.05f, ForceMode.VelocityChange);
       }
       if(verticalMove <= -0.1f) {
           rb.AddForce(0, 0, -0.1f, ForceMode.VelocityChange);
       }
       if(verticalMove <= -0.15f) {
           rb.AddForce(0, 0,- 0.15f, ForceMode.VelocityChange);
       }
       if(verticalMove <= -0.2f) {
           rb.AddForce(0, 0, -0.2f, ForceMode.VelocityChange);
       }
       if(rb.position.y <= -1f) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(Input.GetKey("d")) {
            rb.AddForce(inDreapta, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")) {
            rb.AddForce(inStanga, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("s")) {
            rb.AddForce(0, 0, inSpate);
        }
        if(Input.GetKey("w")) {
            rb.AddForce(0, 0, inFata);
        }
        if(Input.GetKey("space")) {
            rb.AddForce(0, saritura, 0);
        }
    }
    //  private int leftFingerId, rightFingerId;
    // private float halfScreenWidth;
//  void Start()
//     {
//         leftFingerId = -1;
//         rightFingerId = -1;
//         halfScreenWidth = Screen.width / 2;
//     }
//     public float rotateSpeed = 1f;
//     void Update() {
//         // Iterate through all the detected touches
//         if (Input.touchCount > 0)
// {
//             Touch first = Input.GetTouch (0);
//             if (first.phase == TouchPhase.Stationary) 
//             {
//                 if(first.position.x < halfScreenWidth) 
//                   rb.AddForce(-0.8f, 0f, 0f, ForceMode.VelocityChange);
//                  if(first.position.x > halfScreenWidth) 
//                  rb.AddForce(0.8f, 0f, 0f, ForceMode.VelocityChange);
//             }
//         }
//     }

}
