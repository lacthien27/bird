using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public abstract class ButtonBase : thienMonoBehaviour
{
    [Header("Button Base")]

    [SerializeField] public GameCtrl gameCtrl;

    [SerializeField] public Button button;

    protected override void Start()
    {
        base.Start();
        this.AddOnClickEvent();
        this.gameCtrl.birdCtrl.gameObject.SetActive(false);
        this.gameCtrl.barrierSpawnerCtrl.gameObject.SetActive(false);
        
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadButton();
    }

    protected virtual void LoadGamectrl()
    {
         if(this.gameCtrl !=null) return;
        this.gameCtrl = GameObject.FindObjectOfType<GameCtrl>(); 
        Debug.LogWarning(transform.name+"LoadGameCtrl",gameObject);
    }

    protected virtual void LoadButton()
    {
        if(this.button != null) return;
        this.button=GetComponent<Button>();
        Debug.LogWarning( transform.name+"loadButton",gameObject);

    }
    protected virtual void AddOnClickEvent()
    {
        
            
            this.button.onClick.AddListener(this.OnClick);
        
    }

    protected abstract  void OnClick();
}
