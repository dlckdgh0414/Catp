using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFollow : MonoBehaviour
{
    private void Awake()
    {
        Vector2 mousePos = Input.mousePosition;
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
}
