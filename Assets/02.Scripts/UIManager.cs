using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    float Time1;
    private void Awake()
    {
        gameObject.SetActive(false);
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
   public void OnClik()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        if(Time1==5)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }
    }
    private void FixedUpdate()
    {
        Time1 += Time.fixedDeltaTime;
    }
}
