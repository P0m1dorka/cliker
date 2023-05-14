using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoseTrain : MonoBehaviour
{
    [SerializeField] private Button _butFirstTrain;
    // Start is called before the first frame update
    void Start()
    {
        _butFirstTrain.onClick.AddListener(ChangeScene);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("Train1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
