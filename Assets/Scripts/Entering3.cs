using UnityEngine;
using UnityEngine.UI;

public class Entering3 : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.Level10Level4();
    }
}
