using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadLevel02() {
        PlayerPrefs.SetInt("Level02", 1);
        SceneManager.LoadScene("Level02");
    } 
    public void LoadLevel03() {
        PlayerPrefs.SetInt("Level03", 1);
        SceneManager.LoadScene("Level03");
    } 
    public void LoadLevel04() {
        PlayerPrefs.SetInt("Level04", 1);
        SceneManager.LoadScene("Level04");
    } 
    public void LoadLevel05() {
        PlayerPrefs.SetInt("Level05", 1);
        SceneManager.LoadScene("Level05");
    }
    public void LoadLevel06() {
        PlayerPrefs.SetInt("Level06", 1);
        SceneManager.LoadScene("Level06");
    }
    public void LoadLevel07() {
        PlayerPrefs.SetInt("Level07", 1);
        SceneManager.LoadScene("Level07");
    } 
    public void LoadLevel08() {
        PlayerPrefs.SetInt("Level08", 1);
        SceneManager.LoadScene("Level08");
    } 
    public void LoadLevel09() {
        PlayerPrefs.SetInt("Level09", 1);
        SceneManager.LoadScene("Level09");
    } 
    public void LoadLevel10() {
        PlayerPrefs.SetInt("Level10", 1);
        SceneManager.LoadScene("Level10");
    }
    public void ChapterFinished() {
        SceneManager.LoadScene("CreditsScene");
    }
}
