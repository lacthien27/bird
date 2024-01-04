using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BrickCtrl : ThienMonoBehaviour
{
    [SerializeField ] public BrickSO brickSO;
    [SerializeField] public BrickDamReceiver brickDamReceiver;

    [SerializeField] protected BrickImpact brickImpact;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickSO();
        this.LoadBrickDamReceiver();
        this.LoadBrickImpact();
    }

    protected virtual void LoadBrickDamReceiver()
    {
        if(this.brickDamReceiver!=null) return;
        this.brickDamReceiver=GetComponentInChildren<BrickDamReceiver>();
        Debug.LogWarning(transform.name +" : LoadBrickDamReceiver",gameObject);
    }

    protected virtual void LoadBrickSO()
    {
        if(this.brickSO!=null) return;
        string resPath = "Brick/"+ transform.name;
        this.brickSO = Resources.Load<BrickSO>(resPath);
        Debug.LogWarning(transform.name+"LoadBrickSO"+resPath,gameObject);
    }
     protected virtual void LoadBrickImpact()
    {
        if(this.brickImpact!=null) return;
        this.brickImpact=GetComponentInChildren<BrickImpact>();
        Debug.LogWarning(transform.name +" : LoadBrickImpact",gameObject);
    }

}
