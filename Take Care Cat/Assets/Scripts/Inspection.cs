using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inspection : MonoBehaviour
{
    [SerializeField] GameObject researchImg;
    public Text informationText;

    RaycastHit hit;
    Ray ray;

    Player player => SystemManager.Instance.Player;

    Animator imgAnim;

    void Awake()
    {
        imgAnim = researchImg.GetComponent<Animator>();
    }

    void Start()
    {
        informationText.text = "";
    }

    void Update()
    {
        RayCasting();
    }

    void RayCasting()
    {
        //Debug.DrawRay(transform.position, transform.forward, Color.green, 1f);

        if (Camera.main == null)
            return;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.tag == "Cat")
                {
                    player.mainCat = hit.transform.gameObject.GetComponent<Cat>();
                    player.mainCat.StartCatCare();
                }

                Explanation(hit.transform.gameObject);


            }
            else
            {
                informationText.text = "";
            }
        }

        
        
    }

    private bool isExplanation;

    /// <summary>
    /// 실질적으로 조사를 하는 함수
    /// </summary>
    /// <param name="obj">조사할 오브젝트</param>
    void Explanation(GameObject obj)
    {
        Object objLogic = obj.GetComponent<Object>();

        if (isExplanation)
            return;

        string explanation;
        if (obj.GetComponent<Object>() == null)
            explanation = "";
        else
        {
            explanation = objLogic.ClickObj();  //조사
            ImgShow();

        }
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

    private void ImgShow()
    {
        imgAnim.SetBool("isShow", true);

    }

}
