using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inspection : MonoBehaviour
{

    public Text informationText;
    RaycastHit hit;
    Ray ray;

    void Start()
    {
        informationText.text = "";
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayCasting();
        }
    }

    void RayCasting()
    {
        //Debug.DrawRay(transform.position, transform.forward, Color.green, 1f);

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {

            Explanation();

        }
        else
        {
            informationText.text = "";
        }
    }

    void Explanation()
    {
        string explanation = "";

        switch (hit.transform.tag)
        {
            case "CopCar":
                explanation = hit.transform.gameObject.GetComponent<Car>().Search();
                break;

            case "OldCar":
                explanation = hit.transform.gameObject.GetComponent<OldCar>().Search();
                break;

            case "Barrel":
                explanation = hit.transform.GetComponent<Barrel>().Search();
                break;

            case "Barrier":
                explanation = hit.transform.GetComponent<Barrier>().Search();
                break;


            default:
                break;
        }



        //조사를 할 수 있다 
        //informationText.text = explanation;
        StartCoroutine(TextAnimation(explanation));
        

    }

    IEnumerator TextAnimation(string explanation)
    {
        for (int i = 0; i < explanation.Length; i++)
        {
            informationText.text += explanation[i];
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(0.1f);
        informationText.text = "";
    }

}
