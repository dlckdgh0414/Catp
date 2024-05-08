using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftManager : MonoBehaviour
{
   [SerializeField]private float currentTime;
   [SerializeField] private float creatTime = 2f;
    public GameObject[] FishPrefab;

    //âȣ�� �ð���
    private void Update()
    {
        if(creatTime<currentTime)
        { 
            int FishIdex = Random.Range(0, FishPrefab.Length);
            Instantiate(FishPrefab[FishIdex], transform.position, Quaternion.identity);
            currentTime = 0;
        }
    }
    private void FixedUpdate()
    {
        currentTime +=Time.fixedDeltaTime;
    }
}
