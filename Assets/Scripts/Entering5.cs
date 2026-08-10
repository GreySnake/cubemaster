using UnityEngine;
using UnityEngine.UI;

public class Entering5 : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.Level10Level6();
    }
}
