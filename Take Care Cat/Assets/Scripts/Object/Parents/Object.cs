using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public string name;
    public string explanation;

    public GameObject researchImg = null;

    Player player => SystemManager.Instance.Player;
    
    // Start is called before the first frame update
    void Start()
    {
        researchImg = Resources.Load("ReserchImage") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 오브젝트를 조사했을 때의 함수
    /// </summary>
    /// <returns></returns>
    public virtual string Search()
    {
        StartCoroutine("ImgShow");

        //메인 텍스트에 오브젝트의 설명을 반환한다
        return explanation;
    }

    IEnumerator ImgShow()
    {
        researchImg.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        researchImg.SetActive(false);
    }
}
