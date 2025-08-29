using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoreSlot : MonoBehaviour
{
    public Image itemImage;
    public TextMeshProUGUI itemDescription;
    public TextMeshProUGUI itemPrice;
    public TextMeshProUGUI quantityText;
    private int currentQuantity;

    public ItemSO currentItem;
    
    public void InitStoreSlot(ItemSO item)
    {
        currentItem = item;
        itemImage.sprite = currentItem.icon;
        itemDescription.text = currentItem.description;
        itemPrice.text = "구매: " + currentItem.price + "골드";
        currentQuantity = 0;
        quantityText.text = "현재 보유: " + currentQuantity;
    }

    public void OnClickButton()
    {
        if (GameManager.Instance.Player.StatInfo.currentGold >= currentItem.price)
        {
            GameManager.Instance.Player.StatInfo.AddItemIntoInventory(currentItem);
            currentQuantity++;
            quantityText.text = "현재 보유: " + currentQuantity;
        }
        else
        {
            return;
        }
    }
}
