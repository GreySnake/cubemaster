using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Level01 : MonoBehaviour {
   public Button button;
   void Start() {
       ColorBlock cb = button.colors;
       cb.normalColor = Color.green;
       button.colors = cb;
   }
}
