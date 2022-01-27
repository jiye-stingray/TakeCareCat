using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoor : Object
{
    // Start is called before the first frame update
    void Start()
    {
        name = "잠긴 문";
        explanation = "잠겨 있어 들어 갈 수 가 없다";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override string Search()
    {
        return base.Search();
    }
}
