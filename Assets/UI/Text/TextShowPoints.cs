using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class TextShowPoints : TextBase
{
    public static TextShowPoints instance;
    [SerializeField] public int point=0;
    protected override void Awake()
    {
        base.Awake();
        TextShowPoints.instance =this;
    }
    protected virtual  void FixedUpdate() 
    {
        this.UpdateCollectPoints();    
    }

    protected virtual void UpdateCollectPoints()
    {
        
        int point=(int)this.gameCtrl.birdCtrl.birdImpact.birdImpactPoint/2;
        this.text.SetText("Score:"+point.ToString());
        
    }
}
