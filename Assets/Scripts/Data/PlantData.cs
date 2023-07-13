using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlantData", menuName = "Data/PlantData", order = 2), Serializable]
public class PlantData : ScriptableObject
{
    public List<PlantInfo> lstPlant;

    public PlantInfo CurrentPlant(int idPlant)
    {
        PlantInfo curPlant = lstPlant.Find(x => x.idPlant == idPlant);
        return curPlant;
    }
}

[Serializable]
public class PlantInfo
{
    public int idPlant;
    public int coinSpent;
    public int playerLvCanUlock;
    public GameObject iconPlant;

    public Mesh smallPlant;
    public Mesh mediumPlant;
    public Mesh bigPlant;

    public float timeToHarvest;
    public PlantRewards rewards;
    public bool IsCanPlant
    {
        get
        {
            if (UserProfile.CurrentCoin >= coinSpent && UserProfile.CurrentLevel >= playerLvCanUlock)
                return true;
            else
                return false;
        }
    }
}

public class PlantRewards
{
    public int coinCollect;
    public int expCollect;
}
