using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TargCheck : MonoBehaviour
{
    private TargetsSPAWN _ts;
    private int _kolvo;
    private void Start()
    {
        _kolvo = PlayerPrefs.GetInt("_targets");
        StartCoroutine(DeleteObjects());
    }

    private IEnumerator DeleteObjects()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
    private void OnMouseUpAsButton()
    {
        _kolvo++;
        PlayerPrefs.SetInt("_targets", _kolvo);
        Destroy(gameObject);
    }
}
