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
        SystemManager.Instance.InformationTextController.informTxt.text = "";
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
                SystemManager.Instance.InformationTextController.informTxt.text = "";
            }
        }

        
        
    }


    /// <summary>
    /// ���������� ���縦 �ϴ� �Լ�
    /// </summary>
    /// <param name="obj">������ ������Ʈ</param>
    void Explanation(GameObject obj)
    {
        Object objLogic = obj.GetComponent<Object>();

        if (SystemManager.Instance.InformationTextController.isExplanation)
            return;

        string explanation;
        if (obj.GetComponent<Object>() == null)
            explanation = "";
        else
        {
            explanation = objLogic.ClickObj();  //����
            ImgShow();

        }
        //���� ���̱�
        
        StartCoroutine(SystemManager.Instance.InformationTextController.TextAnimation(explanation));


    }

    

    private void ImgShow()
    {
        imgAnim.SetBool("isShow", true);
    }

}
