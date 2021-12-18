using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDinfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("is active" + XRSettings.isDeviceActive);
        Debug.Log("name:" + XRSettings.loadedDeviceName);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
