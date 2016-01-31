using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WriteScore : MonoBehaviour {

    public Text tex;
    GameObject scoresave;
    save_and_load saveload;

	// Use this for initialization
	void Start () {
        if (GameObject.Find("ScoreSave"))
        {
            scoresave = GameObject.Find("ScoreSave");
            saveload = scoresave.GetComponent<save_and_load>();
            tex.text = "HISCORE:" + saveload.Load_Score().ToString();
        }
        else tex.text = "HISCORE:0";

        Time.timeScale = 0;


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
