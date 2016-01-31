using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WriteScore : MonoBehaviour {

    public Text tex;
    public GameObject scoresave;
    save_and_load saveload;

 
	// Use this for initialization
	void Start () {


        saveload = scoresave.GetComponent<save_and_load>();
        tex.text = "HISCORE:" + saveload.Load_Score().ToString();
        



    }
	
	// Update is called once per frame
	void Update () {
        
	
	}
}
