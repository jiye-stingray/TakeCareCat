using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : Object
{
    void Start()
    {
        name = "불통";
        explanation = "가까이 가면 몸이 따뜻해진다";
    }

    void Update()
    {
        
    }

    public override string ClickObj()
    {
        return base.ClickObj();
    }

    public override void ReSearch()
    {
        base.ReSearch();
    }

}
