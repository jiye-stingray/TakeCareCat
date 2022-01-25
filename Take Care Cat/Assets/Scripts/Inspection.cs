using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inspection : MonoBehaviour
{
    RaycastHit hit;

    public Text informationText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward,Color.green,0.5f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.5f))
        {
            Debug.Log(hit.transform.name);
            Debug.Log("조사를 하세요");
            
            if (Input.GetKeyDown(KeyCode.E))
            {
           
                //조사를 할 수 있다 
                Debug.Log("조사");
                informationText.text = "이 오브젝트는 " + hit.transform.name + "이다";
            }
            
        }
    }
}
