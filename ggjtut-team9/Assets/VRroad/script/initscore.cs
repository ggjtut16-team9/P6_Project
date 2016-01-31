using UnityEngine;
using System.Collections;

public class initscore : MonoBehaviour {

    public GameObject scoresave;
    save_and_load saveload;
	// Use this for initialization
	void Awake () {
        saveload = scoresave.GetComponent<save_and_load>();
        saveload.InitHiScore();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
