using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirgger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            UIManager.Instance.gameObject.SetActive(true);
            
        }
    }
}
