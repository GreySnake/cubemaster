using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Level05 : MonoBehaviour {
   public Button button;
   void Start() {
       ColorBlock cb = button.colors;
       var level05 = PlayerPrefs.GetInt("Level05");
       if(level05 == 1) {
           cb.normalColor = Color.green;
       } else {
           cb.normalColor = Color.red;
       }
       button.colors = cb;
   }
}
