using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.IO.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;

public class BackGroundSpawner : Spawner
{
    [Header("BackGroundSpawner")]
    public static BackGroundSpawner instance;

    [SerializeField] public float startTime=0;
    [SerializeField] public float elapsedTime =1770f;

    void FixedUpdate()  
    {
        this.Spawning();
    }



    protected override void LoadComponents()
    {
        base.LoadComponents();
        BackGroundSpawner.instance = this;
    }

    protected virtual void Spawning()
    {
        this.startTime+=1;
        if(this.startTime >this.elapsedTime)
        {
        
        Transform objName = this.GetPrefabFromLoop(); // get obj
        Quaternion rot = transform.parent.rotation;
        Vector3 pos = new Vector3(18.1f,-2,0);
        Transform obj = this.Spawn(objName,pos,rot);
        obj.gameObject.SetActive(true);
        this.startTime=0;
        }
        
        
    }

    

  

    
    
}
