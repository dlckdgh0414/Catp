using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(true);
    }
    private void Update()
    {
        StartCoroutine(LoadScene(5f));
    }

    IEnumerator LoadScene(float delaytime)
    {
        yield return new WaitForSeconds(delaytime);
        gameObject.SetActive(false);
    }
}
