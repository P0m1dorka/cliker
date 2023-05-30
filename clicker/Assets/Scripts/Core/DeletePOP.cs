using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeletePOP : MonoBehaviour
{
    private WaitForSeconds _deathTime = new WaitForSeconds(2f);
    [SerializeField] private TMP_Text _text;
    private void Start()
    {
        _text.text = $"+{PlayerPrefs.GetInt("_scaleMoney")}";
        StartCoroutine(Test());
    }
    private IEnumerator Test()
    {
        yield return _deathTime;
        Destroy(gameObject);
    }
   
}
