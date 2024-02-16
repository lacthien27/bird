using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BirdDespawn : Despawner
{
    
    [SerializeField] public  BirdCtrl birdCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.BirdCtrl();
    }

    protected virtual void BirdCtrl()
    {
        if(this.birdCtrl !=null) return;
        this.birdCtrl = GetComponentInParent<BirdCtrl>();
        Debug.LogWarning(transform.name+" :LoadBirdCtrl",gameObject);
    
    }
   
    public override bool CanDespawn()
    {
        if(this.birdCtrl.birdImpact.impact>0)
        {
            return true;
        }
        return false;
    }
    protected override void DespawnByDistance()
    {
        transform.parent.gameObject.SetActive(false);
    }
   

}
