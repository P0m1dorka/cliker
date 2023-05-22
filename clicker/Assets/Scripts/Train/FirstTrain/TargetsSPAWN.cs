using System.Collections;
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
    [SerializeField] private float _maxtime;
    private int maxmish;
    private Vector3 _posTarg; 
    private GameObject _objectTarg;
    private float x ;
    private float y ;
    private float z ;
    private void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("_maxtargets"));
        PlayerPrefs.SetInt("_targets",0);
        maxmish = PlayerPrefs.GetInt("_maxtargets");
        if(maxmish>15){
            PlayerPrefs.SetInt("_maxtargets",15);
        }
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
            Debug.Log(PlayerPrefs.GetInt("_targets")); 
        
        }
    }
    private void Update()
    { 
        _maxtime -= Time.deltaTime;
        Debug.Log(_maxtime);
        if(_maxtime<0)
        {
            SceneManager.LoadScene("MainLVL");
        }
        if(PlayerPrefs.GetInt("_targets") >= maxmish)
        {
            PlayerPrefs.SetInt("_maxtargets",maxmish+1);
            SceneManager.LoadScene("MainLVL");
        }
    }

}
