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

    public override string ClickObj()
    {
        return base.ClickObj();
    }



}
