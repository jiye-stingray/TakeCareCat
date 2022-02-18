using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera catCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCatCamera(Camera catCamera)
    {
        this.catCamera = catCamera;
        mainCamera.enabled = false;
        catCamera.enabled = true;
    }
}
