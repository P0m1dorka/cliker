using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ExitSet);
    }

    private void ExitSet()
    {
       PlayerPrefs.Save();
        SceneManager.LoadScene("MainLVL");
    }
}
