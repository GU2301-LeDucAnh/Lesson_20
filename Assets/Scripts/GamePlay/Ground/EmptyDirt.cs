using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyDirt : MonoBehaviour
{
    public DirtState dirtState;

    private GameObject curPlant;
    public void PlantingPlant(PlantInfo plantInfo)
    {
        if (dirtState != DirtState.EmptyDirt)
            return;

        dirtState = DirtState.HasPlant;
        GameObject plantOnDirt = Instantiate(new GameObject(), gameObject.transform);
        curPlant = plantOnDirt;
    }
}

public enum DirtState
{
    EmptyDirt,
    HasPlant,
}
