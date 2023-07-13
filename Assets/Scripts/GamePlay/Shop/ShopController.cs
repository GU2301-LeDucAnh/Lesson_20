using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    [SerializeField] private TabController lsTab;
    [SerializeField] private ShopItem shopElement;
    [SerializeField] private GameObject scrollViewContentShop;
    [SerializeField] private Button closeBtn;
    public ItemInfo itemInfo;

    public static ShopController Instance;

    public static ShopController Setup()
    {
        if (Instance == null)
        {
            Instance = Instantiate(Resources.Load(PathPrefab.SHOP_BOX) as GameObject).GetComponent<ShopController>();
        }
        return Instance;
    }

    public void Show()
    {
        lsTab.tabPlant.ShowTab();
        closeBtn.onClick.AddListener(ClosePanel);
    }

    public void PlantTab()
    {
        var lstPlant = GameController.Instance.dataManager.plantData.lstPlant;
        for (int i = 0; i < lstPlant.Count; i++)
        {
            var btnSelectPlant = (Instantiate(shopElement.gameObject, scrollViewContentShop.transform) as GameObject).AddComponent<PlantItem>();
            btnSelectPlant.Init(lstPlant[i]);
        }
    }

    public void PlayerSkinTab()
    {
        var lstSkin = GameController.Instance.dataManager.skinData.skins;
        for (int i = 0; i < lstSkin.Count; i++)
        {
            var btnSelectPlant = (Instantiate(shopElement.gameObject, scrollViewContentShop.transform) as GameObject).AddComponent<PlayerSkinItem>();
            btnSelectPlant.Init(lstSkin[i]);
        }
    }

    public void ClosePanel()
    {
        gameObject.SetActive(false);
    }
}

[System.Serializable]
public class TabController
{
    public TabPlant tabPlant;
    public TabPlayerSkin tabPlayerSkin;
}

[System.Serializable]
public class TabBtn
{
    public Button btnTab;
    public virtual void ShowTab()
    {

    }
}

[System.Serializable]
public class TabPlant : TabBtn
{
    public override void ShowTab()
    {
        btnTab.onClick.AddListener(ShopController.Instance.PlantTab);
    }
}

[System.Serializable]
public class TabPlayerSkin : TabBtn
{
    public override void ShowTab()
    {
        btnTab.onClick.AddListener(ShopController.Instance.PlayerSkinTab);
    }
}
