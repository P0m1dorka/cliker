using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsOpen : MonoBehaviour
{
  [SerializeField] private Button _button;
  void Start()
  {
    _button.onClick.AddListener(Test);
  }
  private void Test(){
    Debug.Log("test");
  }
   private void OnMouseDown()
   {
     Debug.Log("Pibo");
   }
}
