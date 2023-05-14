using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoseTrain : MonoBehaviour
{
    [SerializeField] private Button _butFirstTrain;
    void Start()
    {
        _butFirstTrain.onClick.AddListener(ChangeScene);
    }
    private void ChangeScene()
    {
        SceneManager.LoadScene("Train1");
    }
}
