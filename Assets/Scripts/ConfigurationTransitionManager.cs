using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class ConfigurationTransitionManager : MonoBehaviour {

    public static ConfigurationTransitionManager _instance;

    MixedRealityController controller;

    private MixedRealityController.Mode ARMode;

    public int ARSceneLevelNumber;

	// Use this for initialization
	void Start () {

        if(_instance == null)
        {
            _instance = this;
        }

        if(_instance != this)
        {
            Destroy(this);
        }

        DontDestroyOnLoad(this);

        controller = MixedRealityController.Instance;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchToVR()
    {
        //controller.SetMode(MixedRealityController.Mode.VIEWER_AR);
        ARMode = MixedRealityController.Mode.VIEWER_AR;
        LoadARScene();
    }

    public void SwtichToHandheld()
    {
        //controller.SetMode(MixedRealityController.Mode.HANDHELD_AR);
        ARMode = MixedRealityController.Mode.HANDHELD_AR;
        LoadARScene();
    }

    void LoadARScene()
    {
        SceneManager.LoadScene(ARSceneLevelNumber);
        SceneManager.sceneLoaded += OnARSceneLoaded;
    }

    void OnARSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        controller = MixedRealityController.Instance;
        controller.SetMode(ARMode);
    }
}
