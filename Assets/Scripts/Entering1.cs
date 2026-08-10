using UnityEngine;
using UnityEngine.UI;

public class Entering1 : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.Level10Level2();
    }
}
