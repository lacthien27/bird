using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class UICtrl : ThienMonoBehaviour
{
    [SerializeField] public ButtonBase buttonBase;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadButtonBase();
    }

    protected virtual void LoadButtonBase()
    {
        if(this.buttonBase !=null) return;
        this.buttonBase= GameObject.FindObjectOfType<ButtonBase>();
        Debug.LogWarning(transform.name+" : LoadButtonBase",gameObject);
    }



}
