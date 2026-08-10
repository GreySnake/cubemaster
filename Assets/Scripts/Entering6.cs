using UnityEngine;
using UnityEngine.UI;

public class Entering6 : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.Level10Level7();
    }
}
