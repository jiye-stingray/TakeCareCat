using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public string name;
    public string explanation;


    Player player => SystemManager.Instance.Player;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 오브젝트를 클릭했을 때 함수
    /// </summary>
    /// <returns></returns>
    public virtual string ClickObj()
    {

        //메인 텍스트에 오브젝트의 설명을 반환한다
        return explanation;
    }

    /// <summary>
    /// 오브젝트를 조사할 때
    /// </summary>
    public virtual void ReSearch()
    {
        Debug.Log("조사");
    }
    
}
