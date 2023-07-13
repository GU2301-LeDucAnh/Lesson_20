using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public SpriteRenderer normalImg;
    public SpriteRenderer selectedImg;
    public GameObject iconImg;
    public Button curBtn;

    public virtual void ChangeInfo()
    {

    }
}

public class PlantItem : ShopItem
{
    private PlantInfo plantInfo;
    public void Init(PlantInfo plantInfo)
    {
        this.plantInfo = plantInfo;
        iconImg = Instantiate(plantInfo.iconPlant);
        curBtn.onClick.AddListener(ChangeInfo);
    }

    public override void ChangeInfo()
    {
        ShopController.Setup().itemInfo.Init(plantInfo.iconPlant, plantInfo.coinSpent, plantInfo.playerLvCanUlock, plantInfo.rewards.coinCollect, plantInfo.rewards.expCollect);
    }
}
public class PlayerSkinItem : ShopItem
{
    public void Init(SkinInfo skinInfo)
    {
        iconImg = Instantiate(skinInfo.iconSkin);
        curBtn.onClick.AddListener(ChangeInfo);
    }
    public override void ChangeInfo()
    {

    }
}
