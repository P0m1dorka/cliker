using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPC : MonoBehaviour
{
    [SerializeField] private GameObject _oldPC;
    [SerializeField] private GameObject _newPC;
    [SerializeField] private GameObject _newestPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("_qval") <1 && PlayerPrefs.GetInt("_top") < 1)
        {
            _oldPC.SetActive(true);
            _newPC.SetActive(false);
            _newestPC.SetActive(false);
        }
        if(PlayerPrefs.GetInt("_qval")>0 && PlayerPrefs.GetInt("_top") < 1)
        {
            Destroy( _oldPC );
            _newPC.SetActive(true);
            _newestPC.SetActive(false);
        }
        if(PlayerPrefs.GetInt("_top")>0 && PlayerPrefs.GetInt("_qval") > 0)
        {
            _newPC.SetActive(false);
            _newestPC.SetActive(true);
        }
    }
}
