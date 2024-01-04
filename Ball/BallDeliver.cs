using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class BallDeliver : ThienMonoBehaviour
{
    [SerializeField] public  int dame =1;

    [SerializeField] public  BallCtrl ballCtrl;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBallCtrl();
    }

    protected virtual void LoadBallCtrl()
    {
        if(this.ballCtrl!=null) return;
        this.ballCtrl =GetComponentInParent<BallCtrl>();
        Debug.LogWarning(transform.name+ ": LoadBallCtrl",gameObject); 
    }


    public virtual void LoadDamDeliver()
    {
        
        GameCtrl.instance.brickCtrl.brickDamReceiver.Deduct(this.dame);

    }
}
