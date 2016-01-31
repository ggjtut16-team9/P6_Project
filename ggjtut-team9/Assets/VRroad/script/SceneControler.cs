using UnityEngine;
using System.Collections;

public class SceneControler : MonoBehaviour {

    public GameObject scoresave;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
    public void loadTitleScene()
    {
        Application.LoadLevel("TitleScene");
        
    }

    public void loadtestScene()
    {
        DontDestroyOnLoad(scoresave);
        Application.LoadLevel("test");
    }

    public void loadStoryScene()
    {
        DontDestroyOnLoad(scoresave);
        Application.LoadLevel("StoryScene");

    }
}
