using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class BrickImpact : ThienMonoBehaviour
{
    [SerializeField] public BrickCtrl brickCtrl;
    [SerializeField] public BoxCollider2D  boxCollider2D; 

    protected override void LoadComponents()
    {
        base.LoadComponents();
      
        this.LoadBrickCtrl();
        this.LoadBoxCollider2D();
    }

    protected virtual void LoadBrickCtrl()
    {
        if(this.brickCtrl!=null) return;
        this.brickCtrl = GetComponentInParent<BrickCtrl>();
        Debug.LogWarning(transform.name+" : loadBrickCtrl",gameObject);
    }

    

    protected virtual void LoadBoxCollider2D()
    {
        if(this.boxCollider2D !=null) return;
        this.boxCollider2D  = GetComponent<BoxCollider2D>();
        Debug.LogWarning(transform.name+" : loadBox2D",gameObject);

    }

   
}
