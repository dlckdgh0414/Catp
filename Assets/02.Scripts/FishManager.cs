using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//âȣ�� �ð���
public class FishManager : MonoBehaviour
{
    [SerializeField] private float currentTime;
    [SerializeField] private float creatTime = 2f;
    public GameObject[] FishPrefab;

    private void Update()
    {
        if (creatTime < currentTime)
        {
            int FishIdex = Random.Range(0, FishPrefab.Length);
            Instantiate(FishPrefab[FishIdex], transform.position, Quaternion.identity);
            currentTime = 0;
        }
    }
    private void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}

