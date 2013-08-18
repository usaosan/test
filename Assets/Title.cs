using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
	
	public GameObject Btn_Txt_Prefab;
	public Texture Btn_EasyImage;
	public Texture Btn_NormalImage;
	public Texture Btn_HardImage;
	public Texture Btn_QuitImage;
	// Use this for initialization
	void Start () 
	{
		/*GameObject Btn_Easy = Instantiate (Btn_Txt_Prefab) as GameObject;
		Btn_Easy.guiText.text = "Easy";
		Btn_Easy.transform.position = new Vector3(0.5f, 0.5f, 0);
		GameObject Btn_Normal = Instantiate (Btn_Txt_Prefab) as GameObject;
		Btn_Normal.guiText.text = "Normal";
		Btn_Normal.transform.position = new Vector3(0.5f, 0.5f, 0);
		GameObject Btn_Hard = Instantiate (Btn_Txt_Prefab) as GameObject;
		Btn_Hard.guiText.text = "Hard";
		Btn_Hard.transform.position = new Vector3(0.5f, 0.5f, 0);
		GameObject Btn_Quit = Instantiate (Btn_Txt_Prefab) as GameObject;
		Btn_Quit.guiText.text = "Quit";
		Btn_Quit.transform.position = new Vector3(0.5f, 0.5f, 0);
		
		Btn_Easy.transform.Translate(-0.38f,-0.225f, 0);
		Btn_Normal.transform.Translate(0,-0.225f, 0);
		Btn_Hard.transform.Translate(0.38f,-0.225f, 0);
		Btn_Quit.transform.Translate(0,-0.435f, 0);
		*/
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	void OnGUI ()
	{
		GUI.matrix = Matrix4x4.TRS(
			Vector3.zero, 
			Quaternion.identity, 
			new Vector3(Screen.width / 800.0f, Screen.height / 480.0f, 1)
			);
		
		//GUIレイアウトエリア開始;
		GUILayout.BeginArea(new Rect(0,0,Screen.width,Screen.height));
		
		//スタートボタン;
		if(GUI.Button(new Rect(Screen.width/2 - 400,Screen.height/2 + 50,200,80),Btn_EasyImage))
		{
			//1ステージを読み込む;
			Application.LoadLevel(1);	
		}
		//スタートボタン;
		if(GUI.Button(new Rect(Screen.width/2 - 100,Screen.height/2 + 50,200,80),Btn_NormalImage))
		{
			//2ステージを読み込む;
			Application.LoadLevel(2);	
		}
		//スタートボタン;
		if(GUI.Button(new Rect(Screen.width/2 + 200,Screen.height/2 + 50,200,80),Btn_HardImage))
		{
			//3ステージを読み込む;
			Application.LoadLevel(3);	
		}
		//Quitボタン;
		if(GUI.Button(new Rect(Screen.width/2 - 50,Screen.height/2 + 150,100,50),Btn_QuitImage))
		{
			//アプリ終了;
			Application.Quit();	
		}
		
		//GUIレイアウトエリア終了;
		GUILayout.EndArea();
	}
	
	void MakeLayout ()
	{
		GUILayout.BeginVertical();
			//GUILayout.BeginHorizontal();
			
		
		GUILayout.EndArea();
	}
	
}
