using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRub : MonoBehaviour
{
    Animator anim;
    PlayerMove pleyer;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        pleyer = GetComponent<PlayerMove>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            pleyer.speed += 5f;
            anim.SetBool("Run", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            pleyer.speed = 5f;
            anim.SetBool("Run", false);
        }
    }
}
