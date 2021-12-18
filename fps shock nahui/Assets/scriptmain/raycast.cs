using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.CompareTag("target"))
            {
                hit.transform.GetComponent<test>().Damage();
                Debug.Log("ττ");
            }
            if (hit.transform.CompareTag("movtarget"))
            {
                hit.transform.GetComponent<sircle>().Damage();
            }
        }
    }
}
