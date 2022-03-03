using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCanvasController : MonoBehaviour
{
    public GameObject catCanvas;

    public void OnExitBtnClick()
    {
        SystemManager.Instance.CatCanvasController.catCanvas.SetActive(true);
        SystemManager.Instance.CameraController.ShowMainCamera();
    }

    public void OnFeedBtnClick()
    {
        SystemManager.Instance.Player.CheckFood();
    }

}
