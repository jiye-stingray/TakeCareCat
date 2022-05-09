using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed;
    Animator anim;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }


    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float moveSpeed = 0;

        Vector3 moveVec = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));

        if (moveVec.magnitude != 0)
        {
            float run = 1;  //달릴때의 속도 증가
            if (Input.GetKey(KeyCode.LeftShift))
            {
                run = 1.5f;
                moveSpeed = 1;
            }
            else
                moveSpeed = 0.5f;

            transform.Translate(moveVec * speed * run * Time.fixedDeltaTime);
        }
        else
            moveSpeed = 0;


        anim.SetFloat("moveSpeed", moveSpeed);

    }
}
