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
        if (Input.GetMouseButtonDown(0)) Application.LoadLevel("test");


        



    }
}
