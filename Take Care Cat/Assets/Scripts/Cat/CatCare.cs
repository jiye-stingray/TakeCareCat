using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCare : MonoBehaviour
{

    public GameObject CatCanvas;

    int likeable;       //ȣ����
    Player player => SystemManager.Instance.Player;


    void Start()
    {
        CatCanvas.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OnExitBtnClick()
    {
        CatCanvas.SetActive(false);
        SystemManager.Instance.CameraController.ShowMainCamera();
    }

    public void Eat()
    {
        CheckFood();

        player.mainCat.anim.SetTrigger("doEat");
    }

    private void CheckFood()
    {
        //���� Ȯ��

        Feed();
    }

    private void Feed()
    {

    }
}
