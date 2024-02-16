using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;
using UnityEngine.Video;


public class GameCtrl : thienMonoBehaviour
{
    [SerializeField] public  InputCtrl inputCtrl;
    [SerializeField] public BirdCtrl birdCtrl;

    [SerializeField] public  SpawnPoint  spawnPoint;

    [SerializeField ] public BarrierSpawnerCtrl barrierSpawnerCtrl;

    [SerializeField ] public TextBase textBase;
    [SerializeField ] public ButtonBase buttonBase;


    public static GameCtrl instance;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInputCtrl();
        this.LoadBird();
        this.LoadSpawnPoint();
        this.LoadBarrierSpawnCtrl();
        this.LoadUIText();
        this.LoadUIButton();
        GameCtrl.instance = this;
    }
    protected virtual void LoadUIText()
    {
        if(this.textBase !=null) return;
        this.textBase = GameObject.FindObjectOfType<TextBase>(); 
        Debug.LogWarning(transform.name+"LoadTextBase",gameObject);     
    }
    protected virtual void LoadUIButton()
    {
        if(this.buttonBase !=null) return;
        this.buttonBase = GameObject.FindObjectOfType<ButtonBase>(); 
        Debug.LogWarning(transform.name+"LoadButtonBase",gameObject);     
    }


    protected virtual void LoadBarrierSpawnCtrl()
    {
        if(this.barrierSpawnerCtrl !=null) return;
        this.barrierSpawnerCtrl = GameObject.FindObjectOfType<BarrierSpawnerCtrl>(); 
        Debug.LogWarning(transform.name+"LoadBarrierSpawnCtrl",gameObject);     
    }

    protected virtual void LoadInputCtrl()
    {
        if(this.inputCtrl !=null) return;
        this.inputCtrl = GameObject.FindObjectOfType<InputCtrl>(); 
        Debug.LogWarning(transform.name+"LoadinputCtrl",gameObject);      
    }

    protected virtual void LoadBird()
    {
        if(this.birdCtrl !=null) return;
        this.birdCtrl = GameObject.FindObjectOfType<BirdCtrl>(); 
        Debug.LogWarning(transform.name+"LoadbirdCtrl",gameObject);     
    }

    protected virtual void LoadSpawnPoint()
    {
        if(this.spawnPoint!=null) return;
        this.spawnPoint = GameObject.FindObjectOfType<SpawnPoint>(); 
        Debug.LogWarning(transform.name+"LoadSpawnPoint",gameObject);     
    }
}
