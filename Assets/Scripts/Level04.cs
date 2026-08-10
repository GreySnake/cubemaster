using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Level04 : MonoBehaviour {
   public Button button;
   void Start() {
       ColorBlock cb = button.colors;
       var level04 = PlayerPrefs.GetInt("Level04");
       if(level04 == 1) {
           cb.normalColor = Color.green;
       } else {
           cb.normalColor = Color.red;
       }
       button.colors = cb;
   }
}
