using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class save_and_load : MonoBehaviour {

    /// <summary>
    /// PlayerPrefsについて
    /// </summary>
    /// 
    /// 保存可能なのは float , int , string　のみである。
    /// そのため、その他の値は上記の値に変換し保存すること。
    /// PlayerPrefs.SetFloat("保存位置の名前(ここで定義するため自由で良い)",保存する値); でセーブし
    ///                int
    ///                string
    /// 
    /// PlayerPrefs.GetFloat("保存位置の名前"); で保存位置から値を取り出すことができる。
    ///                int
    ///                string
    /// 



    int hiscore;

    Text tex;

    // Use this for initialization
    void Start () {
        //if (GameObject.FindGameObjectsWithTag("scoresave").Length > 1) Destroy(this.gameObject);
        //else DontDestroyOnLoad(this);

//        InitHiScore();


    }

    // Update is called once per frame
    void Update () {
        hiscore = Load_Score();
        //Debug.Log(hiscore);
        if (Input.GetKeyDown(KeyCode.Z)) InitHiScore();
	
	}


    public void Save_Score(int score)
    {
        Debug.Log("ok");
        int hiscore = Load_Score();
        if (score >= hiscore) PlayerPrefs.SetInt("hiscore", score);
        else if (score < hiscore) PlayerPrefs.SetInt("hiscore", hiscore);

    }


    public int Load_Score()
    {
        return PlayerPrefs.GetInt("hiscore");
    }

    public void InitHiScore()
    {
        PlayerPrefs.SetInt("hiscore", 0);
    }
}
