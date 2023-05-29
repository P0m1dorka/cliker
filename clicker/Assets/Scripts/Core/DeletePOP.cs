using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePOP : MonoBehaviour
{
    private WaitForSeconds _deathTime = new WaitForSeconds(2f);
    private void Start()
    {
        StartCoroutine(Test());
    }
    private IEnumerator Test()
    {
        yield return _deathTime;
        Destroy(gameObject);
    }
   
}
