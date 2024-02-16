using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class BirdCtrl : thienMonoBehaviour
{
    [SerializeField] public  GameCtrl gameCtrl;
    [SerializeField] public BirdMovement   birdMovement;
    [SerializeField] public BirdImpact birdImpact;
    
    [SerializeField] public BirdDespawn birdDespawn;

    protected override void LoadComponents()
    {
        this.LoadGameCtrl();
        this.LoadBirdMovement();
        this.LoadBirdImpact();
        this.LoadBirdDespawn();
     
    }

    protected virtual void LoadBirdDespawn()
    {
        if(this.birdDespawn !=null) return;
        this.birdDespawn =  GetComponentInChildren<BirdDespawn>(); 

        Debug.LogWarning(transform.name+":birdDespawn",gameObject);
    }

   

    protected virtual void  LoadGameCtrl()
    {

        if(this.gameCtrl !=null) return;
        this.gameCtrl = GameObject.FindObjectOfType<GameCtrl>(); 
        Debug.LogWarning(transform.name+"LoadGameCtrl",gameObject);
    }
    protected virtual void LoadBirdMovement()
    {
        if(this.birdMovement != null) return;
        this.birdMovement = GetComponentInChildren<BirdMovement>();
        Debug.LogWarning(transform.name+"LoadBirdMovement",gameObject);
    }

    protected virtual void LoadBirdImpact()
    {
        if(this.birdImpact != null) return;
        this.birdImpact = GetComponentInChildren<BirdImpact>();
        Debug.LogWarning(transform.name+"LoadbirdImpact",gameObject);      
    }

    
}
