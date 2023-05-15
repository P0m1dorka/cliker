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
    private float x ;
    private float y ;
    private float z ;
    private void Start()
    {
        maxmish = 9;
        PlayerPrefs.SetInt("_targets", 0);
        StartCoroutine(Spawner());
    }
  
    private IEnumerator Spawner()
    {
       while (true)
        {
            yield return new WaitForSeconds(_coldown);
            float x = UnityEngine.Random.Range(-2f, 2f);
            float y = UnityEngine.Random.Range(0f, 2f);
            _posTarg = new Vector3(x, y, -7.8f);
            Debug.Log(_posTarg);
            _objectTarg = Instantiate(_object, _posTarg, Quaternion.identity);
            yield return new WaitForSeconds(1);
            Destroy(_objectTarg);
        }
    }

    private void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("_targets"));
        if(PlayerPrefs.GetInt("_targets") > maxmish)
        {
            SceneManager.LoadScene("MainLVL");
        }
    }

}
