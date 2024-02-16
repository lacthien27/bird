using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextBase : thienMonoBehaviour
{
    [Header("Text Base")]
    [SerializeField] public TextMeshProUGUI text;
    [SerializeField] public GameCtrl gameCtrl;
   protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadText();
        this.LoadGamectrl();
    }

    protected virtual void LoadGamectrl()
    {
         if(this.gameCtrl !=null) return;
        this.gameCtrl = GameObject.FindObjectOfType<GameCtrl>(); 
        Debug.LogWarning(transform.name+"LoadGameCtrl",gameObject);
    }

    protected virtual void LoadText()
    {
        if(this.text != null) return;
        this.text=GetComponent<TextMeshProUGUI>();
        Debug.LogWarning( transform.name+"LoadText",gameObject);

    }
}
