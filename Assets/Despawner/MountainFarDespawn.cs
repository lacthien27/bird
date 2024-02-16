using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainFarDespawn : Despawner
{
    [SerializeField ]public float disLimitDistance =-30f  ;
    

    protected override void Despawning()// decision  delete object ?  
    {
        if(!this.CanDespawn()) return;// if canDespawn = false  , return stop next steps
        
        this.DespawnByDistance();
        
        
    }
    protected override  void DespawnByDistance()//  active delete 
    {   
       BackGroundSpawner.instance.Despawn(transform.parent);
        
       
       
    }

    public override bool CanDespawn()
    {
        if(transform.parent.position.x <=this.disLimitDistance)
        {
           return true;  
        }        
        return false;
    }
}
