using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFollow : MonoBehaviour
{

    //private Guge G;
    private void Awake()
    {
        Vector2 mousePos = Input.mousePosition;
        //G = GetComponent<Guge>();
    }
    private void Update()
    {
        Mouse();
    }

    private void Mouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fish"))
        {
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.CompareTag("Trash"))
        {
            Destroy(collision.gameObject);
        }
    }
}
