using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CatFoot : MonoBehaviour
{
    [SerializeField] private GameObject catFoot;
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject UI1;
    [SerializeField] private GameObject CatFootLeft;
    int Count;


    public void OnClick()
    {
        StartCoroutine(catMove());
    }

    public void OtherClick()
    {
        StartCoroutine(LeftMove());
    }
    IEnumerator catMove()
    {
        catFoot.transform.DOMove(new Vector3(-9.5f, 0, 0), 1f);
        yield return new WaitForSeconds(1.5f);
        catFoot.transform.DOMove(new Vector3(-20, 0, 0), 1f);
        if (Count == 0)
        {
            UI.transform.DOMove(new Vector3(-25, 0, 0), 1f);
            Count++;
        }
        else
        {
            UI1.transform.DOMove(new Vector3(-25, 0, 0), 1f);
        }
    }
    IEnumerator LeftMove()
    {
        CatFootLeft.transform.DOMove(new Vector3(-20, 0, 0), 2f);
        yield return new WaitForSeconds(1.5f);
        CatFootLeft.transform.DOMove(new Vector3(19, 0, 0), 2.8f);
        UI.transform.DOMove(new Vector3(0, 0, 0), 2f);
    }
}
