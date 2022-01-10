using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeToDestroy : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(TimeToDestroy());
    }

    private IEnumerator TimeToDestroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
