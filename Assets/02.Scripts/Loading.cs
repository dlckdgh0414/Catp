using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    private void Update()
    {
        StartCoroutine(LoadScene(2.5f));
    }

    IEnumerator LoadScene(float delaytime)
    {
        yield return new WaitForSeconds(delaytime);
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
}
