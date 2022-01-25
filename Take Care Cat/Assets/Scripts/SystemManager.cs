using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    static SystemManager instance = null;

    public SystemManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Instance Error");
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    [SerializeField]
    Object objects;
    public Object Objects
    {
        get
        {
            return objects;
        }
    }

    [SerializeField]
    Car car;
    public Car Car
    {
        get
        {
            return car;
        }
    }

    [SerializeField]
    OldCar oldcar;
    public OldCar Oldcar
    {
        get
        {
            return oldcar;
        }
    }
}
