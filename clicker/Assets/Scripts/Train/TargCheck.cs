using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TargCheck : MonoBehaviour
{
    private int _kolvo;
    private void Start()
    {
        _kolvo = PlayerPrefs.GetInt("_targets");
     
    }
    private void OnMouseUpAsButton()
    {
        _kolvo++;
        PlayerPrefs.SetInt("_targets", _kolvo);
        Debug.Log("test");
        Destroy(gameObject);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Zone")
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Zone")
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
