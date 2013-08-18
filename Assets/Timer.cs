using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	
	//タイマー初期値;
	public int MaxTime = 60;
	//ゲームステータス;
	public GameObject Txt_State_Prefab;
	public GameObject Btn_Txt_Prefab;
	public Texture Btn_TryAgainImage;
	public Texture Btn_TopImage;
	public Texture Btn_GiveupImage;
	//残り時間;
	private float time_Remaining;
	
	// Use this for initialization
	void Start () 
	{
		/*
		GameObject Btn_ReTry = Instantiate (Btn_Txt_Prefab) as GameObject;
		Btn_ReTry.name = "Object_ReTry";
		Btn_ReTry.transform.localPosition = new Vector3(0.28f, 0.52f, 0.0f);
		GameObject Btn_Top = Instantiate (Btn_Txt_Prefab) as GameObject;
		Btn_Top.name = "Object_Top";
		Btn_Top.transform.localPosition = new Vector3(0.72f, 0.52f, 0.0f);
		*/
	}
	
	// Update is called once per frame
	void Update () 
	{
		//ステータステキストを検知;
		var Clone_TimeTxt = GameObject.Find("Txt_State(Clone)");
		//スタートしていない場合;
		if (Clone_TimeTxt.guiText.text == "Try 1 min")
		{
			//時間は最大値のまま;
			time_Remaining = MaxTime;
		}
		//スタートしている場合;
		if (Clone_TimeTxt.guiText.text == "")
		{
			//タイムを引く;
			time_Remaining -= Time.deltaTime;
			//残り時間が無くなったら;
			if (time_Remaining <= 0)
			{
				//タイムは0;
				time_Remaining = 0;
				//ステータス表示をタイムアップにする;
				Clone_TimeTxt.guiText.text = "TimeUp!!";
			}
		}
		this.guiText.text = "Time:" + time_Remaining;
	}
	
	void OnGUI()
	{
		//画格に依存しない;
		GUI.matrix = Matrix4x4.TRS(
			Vector3.zero, 
			Quaternion.identity, 
			new Vector3(Screen.width / 800.0f, Screen.height / 480.0f, 1)
			);
		//ステータステキストを検知;
		var Clone_TimeTxt = GameObject.Find("Txt_State(Clone)");
		
		if (Clone_TimeTxt.guiText.text == "TimeUp!!")
		{
			//GUIレイアウトエリア開始--------------[;
			GUILayout.BeginArea(new Rect(0,0,Screen.width,Screen.height));
			//再開ボタン;
			if(GUI.Button(new Rect(Screen.width/2 - 300,Screen.height/2 - 50,250,80),Btn_TryAgainImage))
			{
				//ロードレベル取得;
				int LoadLevel = Application.loadedLevel;
				//ステージを再読み込み;
				Application.LoadLevel(LoadLevel);
			}
			//トップへボタン;
			if(GUI.Button(new Rect(Screen.width/2 + 50,Screen.height/2 - 50,250,80),Btn_GiveupImage))
			{
				//ロードレベル取得;
				int LoadLevel = Application.loadedLevel;
				//トップ画面へ;
				Application.LoadLevel(0);
			}
			GUILayout.EndArea();
			//GUIレイアウトエリア開始--------------];
		}
		else if (Clone_TimeTxt.guiText.text == "Goal")
		{
			//GUI
			GUILayout.BeginArea(new Rect(0,0,Screen.width,Screen.height));
			//
			if(GUI.Button(new Rect(Screen.width/2 - 300,Screen.height/2 - 50,250,80),Btn_TryAgainImage))
			{
				//ロードレベル取得;
				int LoadLevel = Application.loadedLevel;
				//ステージを再読み込み;
				Application.LoadLevel(LoadLevel);
			}
			//トップへボタン;
			if(GUI.Button(new Rect(Screen.width/2 + 50,Screen.height/2 - 50,250,80),Btn_TopImage))
			{
				//ロードレベル取得;
				int LoadLevel = Application.loadedLevel;
				//トップ画面へ;
				Application.LoadLevel(0);
			}
			GUILayout.EndArea();
		}
	}
}
