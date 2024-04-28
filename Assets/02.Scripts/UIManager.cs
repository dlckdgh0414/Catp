using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    Rigidbody2D rigid;
    float Speed = 5f;
    
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        gameObject.SetActive(false);
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
   public void OnClik()
    {
        Time.timeScale = 1;
        StartCoroutine(delay(2));
    }
    IEnumerator delay(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
