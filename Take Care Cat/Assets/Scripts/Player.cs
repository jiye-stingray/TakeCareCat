using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform cameraObj;
    [SerializeField]
    private Transform inspection;
    [SerializeField]
    float speed;
    float checkCollision = 1;
    public int fish = 0;        //����

    Animator anim;

    public Cat mainCat;     //�÷��̾ ���� �����ϰ� �ִ� �����

    void Awake()
    {
        anim = player.GetComponent<Animator>();
    }

    void Update()
    {
        LookAround();
        Move();
    }

    void FixedUpdate()
    {
        JumpCheck();
    }

    /// <summary>
    /// �����̴� �Լ�
    /// </summary>
    private void Move()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        bool isMove = moveInput.magnitude != 0;
        anim.SetBool("isWalking", isMove);
        if (isMove)
        {
            Vector3 lookForward = new Vector3(cameraObj.forward.x,0f,cameraObj.forward.z).normalized;
            Vector3 lookRight = new Vector3(cameraObj.right.x,0f,cameraObj.right.z).normalized;
            Vector3 moveDir = lookForward * moveInput.x + lookRight * moveInput.y;

            player.forward = moveDir;
            inspection.forward = moveDir;

            float runSpeed = 2;
            if (Input.GetButton("Fire3") && isMove)
            {
                anim.SetBool("isRun", true);
                runSpeed = 2;
            }
            else
            {
                anim.SetBool("isRun", false);
                runSpeed = 1;
            }

            if (Input.GetButtonUp("Fire3"))
            {
                anim.SetBool("isRun", false);
            }

            transform.position += moveDir * Time.deltaTime * speed * runSpeed * checkCollision;
        }
        //Debug.DrawRay(cameraObj.position, new Vector3(cameraObj.forward.x,0f,cameraObj.forward.z).normalized ,Color.red);
    }

    /// <summary>
    /// ���콺�� ���⿡ ���� ī�޶� ȸ����Ű�� ���
    /// </summary>
    private void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 cameraAngle = cameraObj.rotation.eulerAngles;

        float x = cameraAngle.x - mouseDelta.y;

        if (x < 180f)
            x = Mathf.Clamp(x, -1f, 70f);
        else
            x = Mathf.Clamp(x, 335f, 361f);


            cameraObj.rotation = Quaternion.Euler(x, 
            cameraAngle.y + mouseDelta.x, cameraAngle.z);
    }

    /// <summary>
    /// ���� Ȯ�� �ϴ� �Լ�
    /// </summary>
    bool isJump;
    void JumpCheck()
    {       
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJump)
                return;

            Jump();

        }
        
    }
    
    /// <summary>
    /// ���� �ϴ� �Լ�
    /// </summary>
    private void Jump()
    {
        isJump = true;
        anim.SetTrigger("isJump");
    }


    public void CheckFood()
    {
        //���� Ȯ��
        if (fish <= 0)
        {
            StartCoroutine(SystemManager.Instance.InformationTextController.TextAnimation("������ ����"));

            Debug.Log("���� ����");
            return;
        }

        mainCat.Feed();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Floor")
        {
            checkCollision = 0;
        }
        else 
        {
            isJump = false;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag != "Floor")
        {
            checkCollision = 1;
        }
    }

    Object obj = null;
    void OnTriggerEnter(Collider other)
    {
        obj = other.GetComponent<Object>();
    }

    void OnTriggerStay(Collider other)
    {
        if (obj != null && Input.GetButtonDown("Research"))
        {
            obj.ReSearch();
        }

        if (other.gameObject.tag == "Barrel")
        {
            Debug.Log("ü��ȸ��?");
        }
    }

    void OnTriggerExit(Collider other)
    {
        obj = null;
    }



}
