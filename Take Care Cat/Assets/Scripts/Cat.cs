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
        int petNum = Random.Range(0,3);
        Debug.Log(petNum);
        anim.SetInteger("Pet", petNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
