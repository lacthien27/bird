using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;



public class SpawnPoint : thienMonoBehaviour
{
  [SerializeField ] protected  List<Transform> points;
    protected override void LoadComponents()
  {
    base.LoadComponents();
    this.LoadPoint();
        

  }
  protected virtual void LoadPoint()
  {
    if(this.points.Count>0) return;
    foreach(Transform point in transform)
    {
      this.points.Add(point);
      
    }

  }
  public virtual Transform GetRanDom1()
  {
    int rand =UnityEngine.Random.Range(0,this.points.Count);
    return this.points[rand];
    
  }

  public virtual Transform GetRanDom2()
  {
    int rand =UnityEngine.Random.Range(0,this.points.Count);
    return this.points[rand];
    
  }
}
