using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerDotween : MonoBehaviour
{
    [SerializeField] GameObject Player;
    private void Update()   
    {
        Player.transform.DOMove(new Vector3(6.6f, -6.61f, 0), 15);
    }
}
