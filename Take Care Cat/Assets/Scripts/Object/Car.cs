using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Object
{

    void Start()
    {
        name = "경찰차";
        explanation = "함부로 조사하면 안 될 거 같다.";
    }

    public override string Search()
    {
        Clarkson();
        return base.Search();
    }

    void Clarkson()
    {
        //빵빵빵 소리가 난다
        //또다른 효과가 뭐가 있을까? 생각해보자

    }

}
