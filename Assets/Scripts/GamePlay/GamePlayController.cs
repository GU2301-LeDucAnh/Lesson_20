using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController Instance;
    public GameUI gameScene;
    public ParticleController particleController;

    public PlayerController playerController;
    private PlantInfo selectedPlant;
    void Awake()
    {
        Instance = this;
        Init();
    }

    // Update is called once per frame
    void Init()
    {
        gameScene.Init();
        selectedPlant = null;
    }

    public void GroundAttach(EmptyDirt emptyDirt)
    {
        gameScene.txtAttachBtn.text = "Plant";
        gameScene.attachBtn.onClick.AddListener(() => {
            if (selectedPlant == null)
                ShopController.Setup().Show();
            else
                emptyDirt.PlantingPlant(selectedPlant); 
        });
    }
}
