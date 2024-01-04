using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : ThienMonoBehaviour
{

    [SerializeField] public PlayerCtrl playerCtrl;

    [SerializeField] public bool isShooting = false;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();

    }

    protected virtual void LoadPlayerCtrl()
    {
        if(this.playerCtrl !=null) return;
        this.playerCtrl =GetComponentInParent<PlayerCtrl>();
        Debug.LogWarning(transform.name+":LoadPlayerCtrl",gameObject);
    }

    void Update()
    {
        this.IsShooting();
    }

    
    public  virtual bool IsShooting()
    {   
        //if( thỏa điều kiện khi lụm đc item)  hoặc mới bắt đầu chơi thì mới sài được cái này
        this.isShooting =  GameCtrl.instance.uICtrl.buttonBase.isShotting==1; 
        return this.isShooting;
    }
}

