using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public string name;
    public string explanation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ������Ʈ�� �������� ���� �Լ�
    /// </summary>
    /// <returns></returns>
    public string Search()
    {
        //���� �ؽ�Ʈ�� ������Ʈ�� ������ ��ȯ�Ѵ�
        return explanation;

    }

}
