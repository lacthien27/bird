using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class BarrierRandom : thienMonoBehaviour
{
    [SerializeField ] protected BarrierSpawnerCtrl barrierSpawnerCtrl;
    [SerializeField] protected float randomDelay =1f;
   [SerializeField]  protected float RandomTimer = 0f;
   [SerializeField]  protected float RandomLimit = 100f;
    protected override void LoadComponents()
   {
    base.LoadComponents();
    this.LoadBarrierSpawnCtrl();
    
   }

    protected virtual void LoadBarrierSpawnCtrl()
    {
         if(this.barrierSpawnerCtrl!= null) return;
        this.barrierSpawnerCtrl = GetComponent<BarrierSpawnerCtrl>();
        Debug.Log(transform.name+":LoadbarrierSpawnerCtrl",gameObject);
    }

    protected virtual  void FixedUpdate() 
    {
        this.Spawning();    
    }
    protected virtual void Spawning()
    {
        if(GameCtrl.instance.birdCtrl.birdImpact.impact>0)
        {
            return;
        }
      this.RandomTimer += Time.fixedDeltaTime;
      if(this.RandomTimer < this.randomDelay ) return;
      this.RandomTimer =0;

        Transform ranPoint1 = GameCtrl.instance.spawnPoint.GetRanDom1(); // get position
        Transform ranPoint2 = GameCtrl.instance.spawnPoint.GetRanDom2(); // get position

        Vector3 Pos1 =  ranPoint1.transform.position;
        Vector3 Pos2 =  ranPoint2.transform.position;

        Quaternion rot = transform.rotation;

        Transform prefab = this.barrierSpawnerCtrl.barrierSpawner.RandomPrefab(); //get object spawn
        Transform obj1 = this.barrierSpawnerCtrl.barrierSpawner.Spawn(prefab.name,Pos1,rot);  
        obj1.gameObject.SetActive(true);

        Transform obj2 = this.barrierSpawnerCtrl.barrierSpawner.Spawn(prefab.name,Pos2,rot);  
        obj2.gameObject.SetActive(true);


    }



}
