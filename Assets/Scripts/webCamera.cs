using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webCamera : MonoBehaviour
{
    // Start is called before the first frame update
    int width = 1920;
    int height = 1080;
    int fps = 60;
    WebCamTexture webcamTexture;
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[0].name, this.width, this.height, this.fps);
        GetComponent<Renderer>().material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}
