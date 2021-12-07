using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject[] Human;
    public GameObject[] Point;

    int h;
    int p;

    bool start = true;
    bool end = false;
    
    void Update()
    {
        if (start)
        {
            start = false;
            StartCoroutine("HumanInst");
        }
        if (end)
        {
            end = false;
            StopCoroutine("HumanInst");
            start = true;
        }
    }

    IEnumerator HumanInst()
    {
        h = Random.Range(0, 3);
        p = Random.Range(0, 5);
        Instantiate(Human[h], Point[p].transform.position, Point[p].transform.rotation);
        yield return new WaitForSeconds(1f);
        Debug.Log("4초 지남 새로운인간 컴온");
        end = true;
    }

}
