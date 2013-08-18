using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	
	private Vector3 Accel;

	public int MoveSize;
	public GameObject Text_Obj;
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveCamera();
		
		var Clone_StateTxt = GameObject.Find("Txt_State(Clone)");
		if(Clone_StateTxt.guiText.text == "Try 1 min" || Clone_StateTxt.guiText.text == "TimeUp!!" || Clone_StateTxt.guiText.text == "Goal")
		{ 
			return;
		}
		
		this.Accel = Input.acceleration;
		Move_To(this.Accel);
	}
	
	//カメラ移動;
	void moveCamera(){
		Vector3 Position = transform.position;
		Position.y = Position.y + 5;
		Position.z = Position.z - 4;
		Camera.main.transform.position = Position;
	}
	
	//ボール移動;
	void Move_To(Vector3 K)
	{
		//引数のベクトルに力を加える;
		transform.rigidbody.AddForce(K.x * MoveSize,0,K.y * MoveSize,ForceMode.VelocityChange);
	}
	
	//ボール衝突した時;
	void OnCollisionEnter(Collision Target_Object)
	{
		//衝突したオブジェクトがゴールの場合;
		if(Target_Object.gameObject.name == "Goal_Col")
		{	 
			var Clone_StateTxt = GameObject.Find("Txt_State(Clone)");
			Clone_StateTxt.guiText.text = "Goal";				//ゴールのテキストを表示;
			//Play_Flg = false;					//プレイフラグを無効にする;
			int NextLoadLevel = Application.loadedLevel + 1;
			if (NextLoadLevel < 4)
			{
				//Application.LoadLevel(NextLoadLevel);	//次のステージを読み込む;
			}
			
		}
	}
}
