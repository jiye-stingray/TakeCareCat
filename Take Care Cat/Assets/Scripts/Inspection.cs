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


    void Awake()
    {

    }

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
            Explanation(hit.transform.gameObject);
            
        }
        else
        {
            informationText.text = "";
        }
    }

    private bool isExplanation;

    /// <summary>
    /// 실질적으로 조사를 하는 함수
    /// </summary>
    /// <param name="obj">조사할 오브젝트</param>
    void Explanation(GameObject obj)
    {
        if (isExplanation)
            return;

        string explanation;
        if (obj.GetComponent<Object>() == null)
            explanation = "";
        else
            explanation = obj.GetComponent<Object>().Search();  //조사


        //글자 보이기
        StartCoroutine(TextAnimation(explanation));
        

    }

    IEnumerator TextAnimation(string explanation)
    {
        isExplanation = true;
        for (int i = 0; i < explanation.Length; i++)
        {
            informationText.text += explanation[i];
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(0.1f);
        informationText.text = "";
        isExplanation = false;
    }

    
}
