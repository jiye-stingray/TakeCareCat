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
        RayCasting();
    }

    void RayCasting()
    {
        //Debug.DrawRay(transform.position, transform.forward, Color.green, 1f);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 1f))
        {

            Debug.Log("���縦 �ϼ���");
            Debug.Log(hit.transform.name);

            


            if (Input.GetKeyDown(KeyCode.E))
            {
                Explanation();
            }

        }
        else
        {
            informationText.text = "";
        }
    }

    void Explanation()
    {
        string explanation = "";
        if (hit.transform.gameObject.name.Contains("CopCar"))
        {
            explanation = hit.transform.gameObject.GetComponent<Car>().Search();

        }
        if (hit.transform.gameObject.name.Contains("OldCar"))
        {
            explanation = hit.transform.gameObject.GetComponent<OldCar>().Search();

        }

        //���縦 �� �� �ִ� 
        Debug.Log("����");
        informationText.text = explanation;

    }

}
