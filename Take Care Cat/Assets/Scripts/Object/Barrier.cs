using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : Object
{
    // Start is called before the first frame update
    void Start()
    {
        name = "울타리";
        explanation = "이 너머로는 갈 수 없을 것 같다.";
    }

    // Update is called once per frame
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
