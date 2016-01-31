using UnityEngine;
using System.Collections;

public class ScoreCount : MonoBehaviour {

    public SpriteRenderer count1;
    public SpriteRenderer count2;

    public GameObject score;


    public Sprite[] count = new Sprite[10];

    GameObject player;
    CameraMove cameramove;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
        cameramove = player.GetComponent<CameraMove>();
	
	}
	
	// Update is called once per frame
	void Update () {
        switch (cameramove.score)
        {
            case 0:
                count1.sprite = count[0];
                count2.sprite = count[0];
                break;
            case 1:
                count1.sprite = count[1];
                count2.sprite = count[1];
                break;
            case 2:
                count1.sprite = count[2];
                count2.sprite = count[2];
                break;
            case 3:
                count1.sprite = count[3];
                count2.sprite = count[3];
                break;
            case 4:
                count1.sprite = count[4];
                count2.sprite = count[4];
                break;
            case 5:
                count1.sprite = count[5];
                count2.sprite = count[5];
                break;
            case 6:
                count1.sprite = count[6];
                count2.sprite = count[6];
                break;
            case 7:
                count1.sprite = count[7];
                count2.sprite = count[7];
                break;
            case 8:
                count1.sprite = count[8];
                count2.sprite = count[8];
                break;
            case 9:
                count1.sprite = count[9];
                count2.sprite = count[9];
                break;
            case 10:
                score.SendMessage("Save_Score", cameramove.score);
                DontDestroyOnLoad(score);
                Application.LoadLevel("TitleScene");
                break;
        }

    }
}
