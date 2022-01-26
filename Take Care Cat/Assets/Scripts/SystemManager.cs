using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    static SystemManager instance = null;

    public static SystemManager Instance
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
    Player player;
    public Player Player
    {
        get
        {
            return player;
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
