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
    Inspection inspection;

    [SerializeField]
    CameraController cameraController;
    public CameraController CameraController
    {
        get
        {
            return cameraController;
        }
    }


    [SerializeField]
    CatCare catCare;
    public CatCare CatCare
    {
        get
        {
            return catCare;
        }
    }
}
