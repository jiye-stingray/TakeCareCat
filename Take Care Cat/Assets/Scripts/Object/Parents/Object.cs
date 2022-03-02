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
    /// ������Ʈ�� Ŭ������ �� �Լ�
    /// </summary>
    /// <returns></returns>
    public virtual string ClickObj()
    {

        //���� �ؽ�Ʈ�� ������Ʈ�� ������ ��ȯ�Ѵ�
        return explanation;
    }

    /// <summary>
    /// ������Ʈ�� ������ ��
    /// </summary>
    public virtual void ReSearch()
    {
        Debug.Log("����");
    }
    
}
