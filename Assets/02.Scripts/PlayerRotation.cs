using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerDotween : MonoBehaviour
{
    RaycastHit2D Hille;
    private bool HilleHiet;
    [SerializeField] Transform drawLineObject;

    private void OnDrawGizmos()
    {
        DrawRay();
    }
    private void DrawRay()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(drawLineObject.position,drawLineObject.position+Vector3.down*2);
    }
}
