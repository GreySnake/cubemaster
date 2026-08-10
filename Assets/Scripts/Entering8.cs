using UnityEngine;
using UnityEngine.UI;

public class Entering8 : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.Level10Level9();
    }
}
