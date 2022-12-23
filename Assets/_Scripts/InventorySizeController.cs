using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySizeController : MonoBehaviour
{
    #region Variables
    
    // Public Variables
    
    // Private Variables
    [SerializeField] private InventoryItem inventoryItemBGPrefab;
    
    #endregion Variables

    public void SetInventoryItems(int itemCount)
    {
        for (int i = 0; i < itemCount; i++)
        {
            var invItem = Instantiate(inventoryItemBGPrefab, transform);
            invItem.SetIndex(i);
        }
    }
}
