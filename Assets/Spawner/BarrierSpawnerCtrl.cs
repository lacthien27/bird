using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BarrierSpawnerCtrl : thienMonoBehaviour
{
    [SerializeField ] public BarrierSpawner barrierSpawner;
    [SerializeField ] public BarrierRandom barrierRandom;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBarrierRandom();
        this.LoadBarrierSpawer();
    }


    protected virtual void LoadBarrierRandom()
    {
        if(this.barrierRandom !=null) return;
        this.barrierRandom =GetComponent<BarrierRandom>();
        Debug.LogWarning(transform.name+ "LoadBarrierRandom", gameObject);

    }

    protected virtual void LoadBarrierSpawer()
    {
        if(this.barrierSpawner !=null) return;
        this.barrierSpawner =GetComponent<BarrierSpawner>();
        Debug.LogWarning(transform.name+ "LoadBarrierSpawner", gameObject);
    }
}
