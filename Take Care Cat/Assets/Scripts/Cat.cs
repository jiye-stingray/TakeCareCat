using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public string name;
    public float likeable;
    public float hunger;

    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    // Start is called before the first frame update
    void Start()
    {
        PetIdle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 고양이의 처음 포즈를 결정하는 함수
    /// </summary>
    private void PetIdle()
    {
        int petNum = Random.Range(0, 3);
        Debug.Log(petNum);

        anim.SetInteger("Pet", petNum);
    }

    /// <summary>
    /// 플레이어가 고양이를 선택했을 때 함수
    /// </summary>
    public void StartCatCare()
    {
        Debug.Log("돌보자");
        Camera catCamera = gameObject.GetComponentInChildren<Camera>();
        SystemManager.Instance.CameraController.ShowCatCamera(catCamera);
    }
}
