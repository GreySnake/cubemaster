using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
    public PlayerFreeMovement movement;
    public GameManager gameManager;
    void OnCollisionEnter (Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacol") {
         
         movement.enabled = false;   
         gameManager.EndGame();
        }
        if(collisionInfo.collider.tag == "Return to Main Menu") {
            SceneManager.LoadScene("Menu");
        }
    }
}
