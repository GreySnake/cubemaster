using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    public bool falling = true;
    public int numberLevel;
    public GameObject LevelCompleteUI;
    public GameObject Joystick;
    public GameObject Level2Complete;
    public GameObject Level3Complete;
    public GameObject Level4Complete;
    public GameObject Level5Complete;
    public GameObject Level6Complete;
    public GameObject Level7Complete;
    public GameObject Level8Complete;
    public GameObject Level9Complete;
    

    public void LevelComplete() { 
        LevelCompleteUI.SetActive(true);  
    }
    public void Level10Level2() { 
        Level2Complete.SetActive(true);  
    }
    public void Level10Level3() { 
        Level3Complete.SetActive(true);  
    }
    public void Level10Level4() { 
        Level4Complete.SetActive(true);  
    }
    public void Level10Level5() { 
        Level5Complete.SetActive(true);  
    }
    public void Level10Level6() { 
        Level6Complete.SetActive(true);  
    }
    public void Level10Level7() { 
        Level7Complete.SetActive(true);  
    }
    public void Level10Level8() { 
        Level8Complete.SetActive(true);  
    }
    public void Level10Level9() { 
        Level9Complete.SetActive(true);  
    }

    public void EndGame() {
        if(falling == true) {
            falling = false;
            Invoke("Restart", 2f);
        }
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void curentLevel() {
        numberLevel = SceneManager.GetActiveScene().buildIndex;
    }
}
