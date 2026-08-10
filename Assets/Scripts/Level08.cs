using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Level08 : MonoBehaviour {
   public Button button;
   void Start() {
       ColorBlock cb = button.colors;
       var level08 = PlayerPrefs.GetInt("Level08");
       if(level08 == 1) {
           cb.normalColor = Color.green;
       } else {
           cb.normalColor = Color.red;
       }
       button.colors = cb;
   }
}
