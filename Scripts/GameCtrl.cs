using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : ThienMonoBehaviour
{


  [SerializeField] public PlayerCtrl playerCtrl;
  [SerializeField] public BallCtrl ballCtrl;
  [SerializeField] public UICtrl uICtrl;
  [SerializeField] public static GameCtrl instance;

  [SerializeField] public ButtonBase buttonBase;

  [SerializeField] public BrickCtrl brickCtrl;

  [SerializeField] public ItemDropSpawner itemDropSpawner;

    protected override void Awake()
    {
        base.Awake();
        GameCtrl.instance= this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
        this.LoadBallCtrl();
        this.LoadUICtrl();
        this.LoadButtonBase();
        this.LoadBrickCtrl();
        this.LoadItemDropSpawner();

    }


    protected virtual void LoadBrickCtrl()
    {
        if(this.brickCtrl!=null) return;
        this.brickCtrl =GameObject.FindObjectOfType<BrickCtrl>();
        Debug.LogWarning(transform.name+ ": LoadBrickCtrl",gameObject);
    }
    protected virtual void LoadItemDropSpawner()
    {
        if(this.itemDropSpawner!=null) return;
        this.itemDropSpawner =GameObject.FindObjectOfType<ItemDropSpawner>();
        Debug.LogWarning(transform.name+ ": LoadItemDropSpawner",gameObject);
    }

    protected virtual void LoadButtonBase()
    {
        if(this.buttonBase != null) return;
        this.buttonBase= GameObject.FindObjectOfType<ButtonBase>();
        Debug.LogWarning(transform.name+" : LoadButtonBase",gameObject);
    }

    protected virtual void LoadUICtrl()
    {
        if(this.uICtrl != null) return;
        this.uICtrl= GameObject.FindObjectOfType<UICtrl>();
        Debug.LogWarning(transform.name+" : LoadUICtrl",gameObject);
    }

    protected virtual void LoadPlayerCtrl()
    {
        if(this.playerCtrl != null) return;
        this.playerCtrl = GameObject.FindObjectOfType<PlayerCtrl>();
        Debug.LogWarning(transform.name+" : LoadPlayerCtrl",gameObject);
    }

    protected virtual void LoadBallCtrl()
    {
        if(this.ballCtrl !=null) return;
        this.ballCtrl = GameObject.FindObjectOfType<BallCtrl>();
        Debug.LogWarning(transform.name+" : LoadBallCtrl",gameObject);

    }
}
