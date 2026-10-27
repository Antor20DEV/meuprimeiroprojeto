using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemScale : MonoBehaviour
{
    public RectTransform squareTransform;
    public float scaleAmount = 1.2f;

    public void Increase()
    {
        squareTransform.localScale *= scaleAmount;
       

    }
   


   
   
    
}
