using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoryControler : MonoBehaviour {

    public Image image;
    public Sprite[] story = new Sprite[10];
    int count = 0;



	// Use this for initialization
	void Start () {
        image.sprite = story[0];
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) count++;

        switch (count)
        {
            case 1:
                image.sprite = story[1];
                break;
            case 2:
                image.sprite = story[2];
                break;
            case 3:
                image.sprite = story[3];
                break;
            case 4:
                image.sprite = story[4];
                break;
            case 5:
                image.sprite = story[5];
                break;
            case 6:
                image.sprite = story[6];
                break;

        }



    }
}
