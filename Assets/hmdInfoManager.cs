using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class hmdInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!XRSettings.isDeviceActive) {
            Debug.Log("No HMD detected");
            return;
        }
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName == "MockHMDDisplay")) {
            Debug.Log("Mock HMD detected");
            return;
        }
        else {
            Debug.Log("HMD detected: " + XRSettings.loadedDeviceName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
