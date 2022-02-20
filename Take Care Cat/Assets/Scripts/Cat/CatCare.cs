using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCare : MonoBehaviour
{

    public GameObject CatCanvas;

    void Start()
    {
        CatCanvas.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OnExitBtnClick()
    {
        Debug.Log("btn click");
        CatCanvas.SetActive(false);
        SystemManager.Instance.CameraController.ShowMainCamera();
    }
}
