using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TargCheck : MonoBehaviour
{
    [SerializeField] private Button _targ;
    private int _kolvo;
    private void Start()
    {
        _kolvo = PlayerPrefs.GetInt("_targets");
        _targ.onClick.AddListener(OnMouseDown);
    }
    private void OnMouseDown()
    {
        _kolvo++;
        PlayerPrefs.SetInt("_targets", _kolvo);
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

    }
}
