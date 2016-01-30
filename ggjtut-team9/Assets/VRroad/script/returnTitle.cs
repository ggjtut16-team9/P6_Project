using UnityEngine;
using System.Collections;

public class returnTitle : MonoBehaviour {

    public GameObject player;
    CameraMove cameramove;
    public GameObject score;

	// Use this for initialization
	void Start () {
        cameramove = player.GetComponent<CameraMove>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            score.SendMessage("Save_Score", cameramove.score);
            DontDestroyOnLoad(score);
            Application.LoadLevel("titleScene");
        }
	}
}
