using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    #region Variables
    
    // Public Variables
    public int Index => _index;
    
    // Private Variables
    private int _index;
    
    #endregion Variables

    public void SetIndex(int index)
    {
        _index = index;
    }
}
