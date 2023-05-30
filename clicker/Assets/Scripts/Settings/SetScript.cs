using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetScript : MonoBehaviour
{

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Open);
    }
    private void Open()
    {
        SceneManager.LoadScene("Settings");
    }
}
