using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindDoor : Object
{
    // Start is called before the first frame update
    void Start()
    {
        name = "막힌 문";
        explanation = "무엇을 막으려고 한 걸까?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override string ClickObj()
    {
        return base.ClickObj();
    }
}
