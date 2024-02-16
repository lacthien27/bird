using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner :  Spawner

{
    public static FXSpawner  instance;

    public static string Smoke_1 ="Smoke_1";


    protected override void Awake()
    {
        base.Awake();
        if(FXSpawner.instance!=null) Debug.LogWarning("only 1 FXSpawner");
        FXSpawner.instance =this;
    }
}
