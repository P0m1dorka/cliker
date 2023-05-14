using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TargetsSPAWN : TargCheck
{
    [SerializeField] private float _coldown;
    [SerializeField] private GameObject _object;
    private int maxmish;
    private Vector3 _posTarg; 
    private GameObject _objectTarg;
   
    private void Start()
    {
        maxmish = 5;
        PlayerPrefs.SetInt("_targets", 0);
        StartCoroutine(Spawner());
    }
  
    private IEnumerator Spawner()
    {
       while (true)
        {
            yield return new WaitForSeconds(1);
            _objectTarg = Instantiate(_object,transform.position,Quaternion.identity);
            yield return new WaitForSeconds(1);
            Destroy(_objectTarg);
        }
    }

    private void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("_targets"));
        Debug.Log(PlayerPrefs.GetInt("_targets"));
        if(PlayerPrefs.GetInt("_targets") > maxmish)
        {
            SceneManager.LoadScene("MainLVL");
        }
        
    }

}
