using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Trade : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(End);
    }
    private void End()
    {
        if (PlayerPrefs.GetInt("_almazi") >= 40)
        {
            SceneManager.LoadScene("Final");
        }
    }
}
