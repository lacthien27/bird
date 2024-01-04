using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : ThienMonoBehaviour
{

    [SerializeField] public float  speed = 0.5f;

    void Update()
    {
        this.LoadMove();
    }

    protected virtual void LoadMove()
    {
        transform.parent.Translate(Vector2.down*this.speed*Time.deltaTime);
    }
}
