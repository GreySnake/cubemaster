using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    public void Back() {
        SceneManager.LoadScene("Menu");
    }
    public void Obstacles() {
        SceneManager.LoadScene("AllObstacles");
    }
}
