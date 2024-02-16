using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneDespawn : Despawner
{
    [SerializeField ] public  float diLimitDistance =-13f;





   public override bool CanDespawn()
    {
        if(transform.parent.position.x <this.diLimitDistance)
        {
           return true;  
        }        
        return false;
    }
     protected override  void DespawnByDistance()//  active delete 
    {   
      BarrierSpawner.instance.Despawn(transform.parent);
      
    }
}
