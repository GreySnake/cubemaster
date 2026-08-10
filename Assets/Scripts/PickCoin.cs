using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PickCoin : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Coin") {
            Destroy(col.gameObject);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            Debug.Log("You picked up a coin! Now you have " + PlayerPrefs.GetInt("Coins") + " coins.");
        }
    }
}
