using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 40;
    public int coins = 5;

    public void SavePlayer() {
        SaveSystem.SavePlayer(this);
    }
        public void LoadPlayer() {
            PlayerData data = SaveSystem.LoadPlayer();
            //coins = data.coins;
        }
}
