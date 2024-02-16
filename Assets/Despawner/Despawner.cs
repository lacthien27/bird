using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using UnityEngine;

public abstract class Despawner : thienMonoBehaviour
{   
     void Update()
     {
        this.Despawning();
     }

    protected virtual void Despawning()// decision  delete object ?  
    {
        if(!this.CanDespawn()) return;// if canDespawn = false  , return stop next steps
        
        this.DespawnByDistance();
        
        
    }
    protected virtual  void DespawnByDistance()//  active delete 
    {   

    }

    public  virtual   bool CanDespawn()  // check condition die?
    {
      return false;
    }
    
  
     
}
