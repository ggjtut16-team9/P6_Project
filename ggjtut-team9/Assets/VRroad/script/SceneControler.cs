using UnityEngine;
using System.Collections;

public class SceneControler : MonoBehaviour {

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
        Application.LoadLevel("test");
    }

    public void loadStoryScene()
    {
        Application.LoadLevel("StoryScene");
    }
}
