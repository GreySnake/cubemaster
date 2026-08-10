using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Level09 : MonoBehaviour {
   public Button button;
   void Start() {
       ColorBlock cb = button.colors;
       var level09 = PlayerPrefs.GetInt("Level09");
       if(level09 == 1) {
           cb.normalColor = Color.green;
       } else {
           cb.normalColor = Color.red;
       }
       button.colors = cb;
   }
}
