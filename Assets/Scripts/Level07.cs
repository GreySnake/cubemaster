using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Level07 : MonoBehaviour {
   public Button button;
   void Start() {
       ColorBlock cb = button.colors;
       var level07 = PlayerPrefs.GetInt("Level07");
       if(level07 == 1) {
           cb.normalColor = Color.green;
       } else {
           cb.normalColor = Color.red;
       }
       button.colors = cb;
   }
}
