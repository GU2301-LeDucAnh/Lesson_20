using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public MusicManager musicManager;
    public UserProfile userProfile;
    public DataManager dataManager;

    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
        Init();
    }

    public void Init()
    {
        musicManager.Init();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
}
