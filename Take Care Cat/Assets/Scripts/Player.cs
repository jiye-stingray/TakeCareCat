using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform cameraObj;

    Animator anim;

    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

    void Update()
    {
        LookAround();
    }

    /// <summary>
    /// 마우스의 방향에 따라 카메라를 회전시키는 기능
    /// </summary>
    private void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 cameraAngle = cameraObj.rotation.eulerAngles;

        cameraObj.rotation = Quaternion.Euler(cameraAngle.x - mouseDelta.y, 
            cameraAngle.y + mouseDelta.x, cameraAngle.z);
    }
}
