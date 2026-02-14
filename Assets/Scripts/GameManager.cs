using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public CameraManager CameraManager { get; private set; } 
    public UiManager UiManager { get; private set; }

    protected override void Awake()
    {
        //base.Awake();
        CameraManager = GetComponent<CameraManager>();
        UiManager = GetComponent<UiManager>();
    }
}
