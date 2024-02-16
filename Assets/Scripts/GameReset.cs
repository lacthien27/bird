using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameReset : thienMonoBehaviour
{
    public static GameReset instance;
    [SerializeField ] public GameCtrl gameCtrl;
    [SerializeField ] public Vector3 pos = new Vector3(0,6,0);
    [SerializeField] public int pointStart=0;
    [SerializeField] public GameObject bird;



    protected override void Awake()
    {
        base.Awake();
        GameReset.instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGameCtrl();
    }

  
    protected virtual void LoadGameCtrl()
    {
        if(this.gameCtrl !=null) return;
        this.gameCtrl = GameObject.FindObjectOfType<GameCtrl>(); 
        Debug.LogWarning(transform.name+":LoadBirdCtrl",gameObject);
    }
    public virtual void PlayAgain()
    {
       

        this.gameCtrl.birdCtrl.birdImpact.impact=0;
        this.bird.gameObject.SetActive(true);
        this.gameCtrl.birdCtrl.transform.position= pos;
        this.gameCtrl.birdCtrl.birdImpact.birdImpactPoint =0;
        
   }
}
