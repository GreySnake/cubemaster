using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class playerRestart : MonoBehaviour
{
    public Transform tr;
    void Update()
    {
     if(Input.GetKey("r")) {
        SceneManager.LoadScene("Level01");
        }
        if(tr.position.y <= -5){
            SceneManager.LoadScene("Level01");
        }
        
    }
}