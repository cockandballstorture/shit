using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sircle : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    public Transform Movespot;
    public float minx;
    public float miny;
    public float minz;
    public float maxx;
    public float maxy;
    public float maxz;
    [SerializeField] private Material col;
    void Start()
    {
        Movespot.position = new Vector3(Random.Range(minx, maxx), Random.Range(miny, maxy), Random.Range(minz, maxz));
    }

    // Update is called once per frame
    void Update()
    {
        //col.color = Color.blue;
        transform.position = Vector3.MoveTowards(transform.position, Movespot.position, Time.deltaTime * speed);
        if (Vector3.Distance(transform.position, Movespot.position) < 0.2f)
        {
            Movespot.position = new Vector3(Random.Range(minx, maxx), Random.Range(miny, maxy), Random.Range(minz, maxz));
        }
    }
    public void Damage()
    {
        col.color = Color.red;
    }

}