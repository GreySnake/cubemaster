using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameManager gameManager;

    public int numberLevel;
    public void StartGame() {
        SceneManager.LoadScene("SelectLevel");
    }
    public void QuitGame() {
        Application.Quit();
    }
    public void OptionsMenu() {
        SceneManager.LoadScene("Tutorial");
    }
    public void CreditsMenu() {
        SceneManager.LoadScene("CreditsButton");
    }
    public void Retry() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void MainMenu() {
        SceneManager.LoadScene("Menu");
    }
    public void LoadLevel1() {
        SceneManager.LoadScene("Level01");
    }
    public void LoadLevel2() {
        var level08 = PlayerPrefs.GetInt("Level02");
        if(level08 == 1) {
            SceneManager.LoadScene("Level02");
        } else {
            SceneManager.LoadScene("LevelNotUnlocked");
        }
    }
    public void LoadLevel3() {
        var level08 = PlayerPrefs.GetInt("Level03");
        if(level08 == 1) {
            SceneManager.LoadScene("Level03");
        } else {
            SceneManager.LoadScene("LevelNotUnlocked");
        }
    }
    public void LoadLevel4() {
        var level08 = PlayerPrefs.GetInt("Level04");
        if(level08 == 1) {
            SceneManager.LoadScene("Level04");
        } else {
            SceneManager.LoadScene("LevelNotUnlocked");
        }
    }
    public void LoadLevel5() {
       var level08 = PlayerPrefs.GetInt("Level05");
        if(level08 == 1) {
            SceneManager.LoadScene("Level05");
        } else {
            SceneManager.LoadScene("LevelNotUnlocked");
        }
    } 
    public void LoadLevel6() {
       var level08 = PlayerPrefs.GetInt("Level06");
        if(level08 == 1) {
            SceneManager.LoadScene("Level06");
        } else {
            SceneManager.LoadScene("LevelNotUnlocked");
        }
    }
    public void LoadLevel7() {
       var level08 = PlayerPrefs.GetInt("Level07");
        if(level08 == 1) {
            SceneManager.LoadScene("Level07");
        } else {
            SceneManager.LoadScene("LevelNotUnlocked");
        }
    }
    public void LoadLevel8() {
       var level08 = PlayerPrefs.GetInt("Level08");
        if(level08 == 1) {
            SceneManager.LoadScene("Level08");
        } else {
            SceneManager.LoadScene("LevelNotUnlocked");
        }
    }
    public void LoadLevel9() {
       var level08 = PlayerPrefs.GetInt("Level09");
        if(level08 == 1) {
            SceneManager.LoadScene("Level09");
        } else {
            SceneManager.LoadScene("LevelNotUnlocked");
        }
    }
    public void LoadLevel10() {
       var level08 = PlayerPrefs.GetInt("Level10");
        if(level08 == 1) {
            SceneManager.LoadScene("Level10");
        } else {
            SceneManager.LoadScene("LevelNotUnlocked");
        }
    }
    public void LevelNotFinished() {
        SceneManager.LoadScene("LevelNotFinished");
    }
    public void NextChapter1() {
        SceneManager.LoadScene("SelectLevel1");
    }
    public void Shop() {
        SceneManager.LoadScene("Shop");
    }
}
