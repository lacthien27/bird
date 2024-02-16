using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCtrl : thienMonoBehaviour
{
    
    [SerializeField] public StoneFly stoneFly;

    [SerializeField] public  StoneImpact stoneImpact;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadStoneFly();
        this.LoadStoneImpact();
    }


    protected virtual void LoadStoneFly()
    {
     if(this.stoneFly != null) return;
       this.stoneFly= GetComponentInChildren<StoneFly>();
        Debug.LogWarning(transform.name+"LoadStoneFLy",gameObject);   
    }

    protected virtual void LoadStoneImpact()
    {   
        if(this.stoneImpact != null) return;
        this.stoneImpact = GetComponentInChildren<StoneImpact>();
        Debug.LogWarning(transform.name+": LoadstoneImpact",gameObject);   
    }
}
