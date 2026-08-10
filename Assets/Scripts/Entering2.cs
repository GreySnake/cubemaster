using UnityEngine;
using UnityEngine.UI;

public class Entering2 : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.Level10Level3();
    }
}
