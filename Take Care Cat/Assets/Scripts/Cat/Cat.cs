using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public string name;
    public float likeable;
    public float hunger;
    Player player => SystemManager.Instance.Player;

    public Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    // Start is called before the first frame update
    void Start()
    {
        //CatCanvas.SetActive(false);
        PetIdle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ������� ó�� ��� �����ϴ� �Լ�
    /// </summary>
    private void PetIdle()
    {
        int petNum = Random.Range(0, 3);
        anim.SetInteger("Pet", petNum);
    }

    /// <summary>
    /// �÷��̾ ����̸� �������� �� �Լ�
    /// </summary>
    public void StartCatCare()
    {
        Camera catCamera = gameObject.GetComponentInChildren<Camera>();
        SystemManager.Instance.CameraController.ShowCatCamera(catCamera);
        SystemManager.Instance.CatCanvasController.catCanvas.SetActive(true);
    }

    /// <summary>
    /// ����̿��� ���� �ִ� �Լ�
    /// </summary>
    public void Feed()
    {
        likeable++;
        player.mainCat.anim.SetTrigger("doEat");
    }
}
