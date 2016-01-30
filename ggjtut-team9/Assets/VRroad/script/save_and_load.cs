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

    ScoreSave scoresave;
    public GameObject save;

    int hiscore;


    // Use this for initialization
    void Start () {
        scoresave = save.GetComponent<ScoreSave>();


        Save_Score(scoresave.score);
	
	}
	
	// Update is called once per frame
	void Update () {
        hiscore = Load_Score();
        Debug.Log(hiscore);
	
	}


    public void Save_Score(int score)
    {
        int hiscore = Load_Score();
        if(score>=hiscore) PlayerPrefs.SetInt("hiscore", score);

    }


    public int Load_Score()
    {
        return PlayerPrefs.GetInt("hiscore");
    }
}
