using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Material col;
    void Start()
    {
        col.color = Color.blue;

    }

    // Update is called once per frame
    void Update()
    {
        col.color = Color.blue;
    }
    public void Damage()
    {
        col.color = Color.red;
    }
}
