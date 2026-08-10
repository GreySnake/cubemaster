using UnityEngine;
using UnityEngine.UI;

public class Entering7 : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.Level10Level8();
    }
}
