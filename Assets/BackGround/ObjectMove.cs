using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class ObjectMove : thienMonoBehaviour
{
    [SerializeField] public float speed=0.5f;

    [SerializeField] public Vector3 eulers;

    protected override void LoadComponents()
    {
        base.LoadComponents();
    }
    void Update()
    {
        this.LoadMountainMove();
        
    }

   





    protected virtual void LoadMountainMove()
    {
         transform.parent.Translate(Vector3.left *this.speed* Time.deltaTime);
    }
}
