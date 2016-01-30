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

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Save()
    {
        Save_Position();//位置をセーブする関数
    }

    void Save_Position()
    {
        PlayerPrefs.SetFloat("PositionX_1", GameObject.Find("Player1").transform.position.x);//　PositionX_1 という場所を作成しそこにプレイヤー1のx位置を代入、セーブする
        PlayerPrefs.SetFloat("PositionY_1", GameObject.Find("Player1").transform.position.y);//以下同様
        PlayerPrefs.SetFloat("PositionZ_1", GameObject.Find("Player1").transform.position.z);

        PlayerPrefs.SetFloat("PositionX_2", GameObject.Find("Player2").transform.position.x);
        PlayerPrefs.SetFloat("PositionY_2", GameObject.Find("Player2").transform.position.y);
        PlayerPrefs.SetFloat("PositionZ_2", GameObject.Find("Player2").transform.position.z);
    }

    public void Load()
    {
        Load_Position();//位置をロードする関数
    }

    void Load_Position()
    {
        GameObject.Find("Player1").transform.position = new Vector3(
                                                            PlayerPrefs.GetFloat("PositionX_1"),// PositionX_1 の値を取り出してPlayer1の位置に代入
                                                            PlayerPrefs.GetFloat("PositionY_1"),//以下同様
                                                            PlayerPrefs.GetFloat("PositionZ_1")
                                                            );

        GameObject.Find("Player2").transform.position = new Vector3(
                                                            PlayerPrefs.GetFloat("PositionX_2"),
                                                            PlayerPrefs.GetFloat("PositionY_2"),
                                                            PlayerPrefs.GetFloat("PositionZ_2")
                                                            );
    }
}
