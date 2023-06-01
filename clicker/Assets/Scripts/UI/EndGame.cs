using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(End());
    }

    private IEnumerator End()
    {
        yield return new WaitForSeconds(3f);
 
        Application.Quit();
  
    }
}
