using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawner : Spawner
{

public static BarrierSpawner instance;


protected override void Awake()
{
    base.Awake();
    
    BarrierSpawner.instance= this;
}
   
}

