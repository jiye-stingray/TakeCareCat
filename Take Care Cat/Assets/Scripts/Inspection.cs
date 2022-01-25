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
            Debug.Log("조사를 하세요");
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                string explanation = "";
                if (hit.transform.gameObject.name.Contains("CopCar"))
                {
                    explanation = hit.transform.gameObject.GetComponent<Car>().Search();

                }
                else if (hit.transform.gameObject.name.Contains("OldCar"))
                {
                    explanation = hit.transform.gameObject.GetComponent<OldCar>().Search();

                }

                //조사를 할 수 있다 
                Debug.Log("조사");
                informationText.text = explanation;
            }
            
        }
    }
}
