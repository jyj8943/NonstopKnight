using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStore : UIBase
{
    public GameObject storePanel;
    public GameObject storeSlots;
    public GameObject storeSlotPrefab;

    [SerializeField] private List<ItemSO> itemList = new List<ItemSO>();
    [SerializeField] public List<StoreSlot> StoreSlotList = new List<StoreSlot>();
    
    private void Start()
    {
        InitStoreUI();
        
        storePanel.SetActive(false);
    }

    private void InitStoreUI()
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            var slot = Instantiate(storeSlotPrefab);
            slot.transform.SetParent(storeSlots.transform);
            slot.GetComponent<StoreSlot>().InitStoreSlot(itemList[i]);
            StoreSlotList.Add(slot.GetComponent<StoreSlot>());
        }
    }

    public void OnClickCloseButton()
    {
        storePanel.SetActive(false);
    }
}
