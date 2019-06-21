using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FinText());
    }

    IEnumerator FinText()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
