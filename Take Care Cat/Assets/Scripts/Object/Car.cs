using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Object
{

    void Start()
    {
        name = "������";
        explanation = "�Ժη� �����ϸ� �� �� �� ����.";
    }

    public override string Search()
    {
        Clarkson();
        return base.Search();
    }

    void Clarkson()
    {
        //������ �Ҹ��� ����
        //�Ǵٸ� ȿ���� ���� ������? �����غ���

    }

}
