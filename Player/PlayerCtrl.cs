using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCtrl : ThienMonoBehaviour
{
    [SerializeField] public PlayerMovement playerMovement;
    [SerializeField] public PlayerImpact playerImpact;

    [SerializeField] public PlayerShooting playerShooting;
    [SerializeField] public GameCtrl gameCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerMovement();
        this.LoadPlayerImpact();
        this.LoadPlayerShooting();
        this.LoadGameCtrl();

    }

    protected virtual void LoadGameCtrl()
    {
        if(this.gameCtrl!=null) return;
        this.gameCtrl =GameObject.FindObjectOfType<GameCtrl>();
        Debug.LogWarning(transform.name+": LoadGameCtrl");
    }
    protected virtual void LoadPlayerShooting()
    {
        if(this.playerShooting!=null) return;
        this.playerShooting =GetComponentInChildren<PlayerShooting>();
        Debug.LogWarning(transform.name+": LoadPlayerShooting");
    }

    protected virtual void LoadPlayerImpact()
    {
        if(this.playerImpact!=null) return;
        this.playerImpact =GetComponentInChildren<PlayerImpact>();
        Debug.LogWarning(transform.name+": LoadPlayerImpact");
    }
    protected virtual void LoadPlayerMovement()
    {
        if(this.playerMovement!=null) return;
        this.playerMovement =GetComponentInChildren<PlayerMovement>();
        Debug.LogWarning(transform.name+": LoadPlayerMovement");
    }
}
