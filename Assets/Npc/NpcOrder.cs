using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;


public class NpcOrder : NpcAbs
{
  [SerializeField] protected Transform foodOrder;

  [SerializeField] protected int loopCount = 1; // số lần lặp để lấy thức ăn

  [SerializeField] public FoodData foodData;// nơi lấy data để so sánh

  [SerializeField] protected List<Transform> foodOrders = new List<Transform>();


public static Action OnSpawnedFood;

  protected override void OnEnable()
  {
    StateOrder.OnComplete_Order += GetFoodToOrder;
    //int loopCount = UnityEngine.Random.Range(1, 3);
  }


  public virtual void GetFoodToOrder()
  {
    if (this.foodOrder != null) return;
     this.foodOrder = GameCtrl.Instance.SpawnerFoodOrder.food;
     var foodOrderCtrl = foodOrder.GetComponent<FoodOrderCtrl>();
     var foodProperties = foodOrderCtrl.FoodOrderPro;
     this.foodData = foodProperties.FoodData;
    /** 
    for (int i = 0; i < this.loopCount; i++)
    {
      Transform foodCtrl = GameCtrl.Instance.SpawnerFoodOrder.SpanwFood();

    }
            OnSpawnedFood?.Invoke();**/


  }
  

  protected override void OnDisable()
  {
    StateOrder.OnComplete_Order -= GetFoodToOrder;
  }
}

