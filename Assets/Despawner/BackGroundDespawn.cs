using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundDespawn : Despawner
{
    
     [SerializeField ]public float disLimitDistance =-6f  ;
    

    protected override void Despawning()// decision  delete object ?  
    {
        if(!this.CanDespawn()) return;// if canDespawn = false  , return stop next steps
        
        this.DespawnByDistance();
        
        
    }
    protected override  void DespawnByDistance()//  active delete 
    {   
    Destroy(transform.parent.gameObject);
       
       
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
