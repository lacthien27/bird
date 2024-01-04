using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDamReceiver : ThienMonoBehaviour
{
    

    [SerializeField] public int hpMax =0;
    [SerializeField] public int hp = 0;
    [SerializeField] protected  BrickCtrl brickCtrl;

    [SerializeField] protected bool isDead = false;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBrickCtrl();
    }

    protected override void ResetValue()
    {
                base.ResetValue();
                this.ReBorn();

    }


    protected virtual void LoadBrickCtrl()
    {
        if(this.brickCtrl !=null) return;
        this.brickCtrl =  transform.parent.GetComponent<BrickCtrl>();
        Debug.LogWarning(transform.name+": LoadBrickCtrl ", gameObject);
    }
    protected virtual void ReBorn()
    {
        this.hpMax= this.brickCtrl.brickSO.hpMax;
        this.hp =this.hpMax;
        
    }

    public virtual void Deduct(int deduct)
    {
        if (this.isDead) return;
        this.hp -= deduct;
        
        if (this.hp < 0) this.hp = 0;
        this.CheckIsDead();
    }
    protected virtual bool IsDead()
    {
        return this.hp <= 0;     // need study more
    }

    protected virtual void CheckIsDead()
    {
        if (!this.IsDead()) return;  // Check to see if it's dead or not v , if yet  go to the next step
        this.isDead = true;
        this.OnDead();
    }

    protected virtual void OnDead()
    {
        this.OnDeadFX();
        this.OnDeadDrop();
        transform.parent.gameObject.SetActive(false);
    }


    protected virtual void OnDeadDrop()
    {
        Vector3 dropPos = transform.parent.position;
        dropPos.z =-1;                                   // quan trọng
        Quaternion dropRot = transform.parent.rotation;
    
        ItemDropSpawner.instance.Drop(this.brickCtrl.brickSO.dropList,dropPos,dropRot);
        
    }

    protected virtual void OnDeadFX()
    {
        
    }

    //  get name of effect when dead 
    // protected virtual  string GetOnDeadFXName()
    // {
    //     return 
    // }




}
