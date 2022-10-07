using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 背包道具类
/// </summary>
public class Item 
{
/// <summary>
/// 道具的形式
/// </summary>
    public enum ItemType
    {
        battery,
        sword
    }
    /// <summary>
    /// 道具的的类型，数量等属性的定义
    /// </summary>
    public ItemType itemType;
    public int amount;
    /// <summary>
    /// 通过单例得到该道具的图片
    /// </summary>
    /// <returns></returns>
    public Sprite GetSprite()
    {
        switch(itemType)
        {
            default:
            case ItemType.battery:
                return ItemAssets.Instance.batter_Spr;
            case ItemType.sword:
                return ItemAssets.Instance.sword_Spr;
        }
    }
}
