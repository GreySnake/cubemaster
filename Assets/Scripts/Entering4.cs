using UnityEngine;
using UnityEngine.UI;

public class Entering4 : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.Level10Level5();
    }
}
