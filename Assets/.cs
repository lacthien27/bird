using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UI;

public class GameReset : thienMonoBehaviour
{   
    public static GameReset instance;
    [SerializeField ] public BirdCtrl birdCtrl;
    [SerializeField ] public Vector3 pos;

    [SerializeField] public int pointStart=0;



    protected override void Awake()
    {
        base.Awake();
        this.LoadStatus();
        GameReset.instance =this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBirdCtrl();
    }
    protected virtual void LoadBirdCtrl()
    {
        if(this.birdCtrl !=null) return;
        this.birdCtrl =GetComponentInParent<BirdCtrl>();
        Debug.LogWarning(transform.name+":LoadBirdCtrl",gameObject);
    }
    protected virtual void LoadStatus()
    {
        this.pos=transform.parent.position;  
        pointStart=0;
        
    }
   // need  condition   lanch

    

    
    public virtual void PlayAgain()
    {
      
         transform.parent.position =pos;
         this.birdCtrl.birdImpact.impact=0;
         transform.parent.gameObject.SetActive(true);

        TextShowPoints.instance.point=pointStart;



       
   }
}
