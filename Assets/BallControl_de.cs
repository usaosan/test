using UnityEngine;
using System.Collections;

public class BallControl_de : MonoBehaviour {
	
	public int MoveSize = 1;
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
		if(Clone_StateTxt.guiText.text == "Try 1 min" || Clone_StateTxt.guiText.text == "TimeUp!!")
		{
			return;
		}
		
		string K = checkKey();
		Move_To(K);
	}
	
	void moveCamera()
	{
		Vector3 Position = transform.position;
		Position.y += 5;
		Position.z -= 4;
		Camera.main.transform.position = Position;
	}
	
	string checkKey()
	{
		if(Input.GetKey (KeyCode.UpArrow))
		{
			return "Up";
		}
		if(Input.GetKey (KeyCode.DownArrow))
		{
			return "Down";
		}
		if(Input.GetKey (KeyCode.LeftArrow))
		{
			return "Left";
		}
		if(Input.GetKey (KeyCode.RightArrow))
		{
			return "Right";
		}
		return null;
	}
	
	void Move_To(string K)
	{
		if(K == "Up")
		{
			transform.rigidbody.AddForce(0,0,MoveSize);
		}
		if(K == "Down")
		{
			transform.rigidbody.AddForce(0,0,MoveSize * -1);
		}
		if(K == "Right")
		{
			transform.rigidbody.AddForce(MoveSize,0,0);
		}
		if(K == "Left")
		{
			transform.rigidbody.AddForce(MoveSize * -1,0,0);
		}
	}
	
	void OnCollisionEnter(Collision Target_Object)
	{
		if(Target_Object.gameObject.name == "Goal_Col")
		{	 
			Text_Obj.guiText.text = "Goal";
			//Play_Flg = false;
		}
	}
}
