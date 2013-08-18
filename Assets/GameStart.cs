using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {
	
	public GUIText Time_Text;
	
	// Use this for initialization
	void Start () 
	{
		this.guiText.text = "Try 1 min";
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetButtonDown("Fire1") && this.guiText.text == "Try 1 min")
		{
			this.guiText.text = "";
			
		}
		
		//キーボードでの操作の場合;
		if (Input.GetKey(KeyCode.Space) && this.guiText.text == "Try 1 min")
		{
			this.guiText.text = "";
		}
		
		//時間のカウント;		
		if (this.guiText.text == "")
		{
			
		}
	}
}
