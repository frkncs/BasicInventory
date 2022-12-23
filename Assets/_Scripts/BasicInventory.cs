using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class BasicInventory : MonoBehaviour
{
    #region Variables
    
    // Public Variables

    // Private Variables
    [SerializeField, Range(1, 9)] private int inventoryItemCount;
    
    private InventorySizeController _inventorySizeController;
    
    #endregion Variables
    
    private void Awake()
    {
        InitComponents();

        SetInventorySize();
    }

    private void InitComponents()
    {
        _inventorySizeController = FindObjectOfType<InventorySizeController>();
    }

    private void SetInventorySize()
    {
        _inventorySizeController.SetInventoryItems(inventoryItemCount);
    }
}
