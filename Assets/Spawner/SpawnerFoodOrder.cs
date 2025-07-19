using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Video;


public class SpawnerFoodOrder : Spawner
{


   [SerializeField] public Transform food;
   public static Action OnSpawnedFood;


    protected override void Awake()
    {
       StateOrder.OnComplete_Order += SpanwFood;

    }


    public virtual void SpanwFood()
    {
         this.food = this.Spawn(this.RandomPrefab(), GameCtrl.Instance.SpawnerNpc.NpcCurrent.position, Quaternion.identity);
         this.food.gameObject.SetActive(true);
         OnSpawnedFood?.Invoke();
        
       
       
       
    }

  


    

}
