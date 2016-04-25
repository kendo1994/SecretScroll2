using UnityEngine;
using System.Collections;

public class PlayerCTrl : MonoBehaviour {

	private Rigidbody2D rb2d;
	public int speed;

	//Bomb
	public static bool BombActivate;
	public static int amountBomb;

	//Item2
	public static bool Item2Activate;
	public static int amountI2;

	public static int itemNow;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		speed = 10;
		BombActivate = false;
		amountBomb = 0;
		itemNow = 0;
	}

	void Update () {

		//PlayerCtrl
		if (Input.GetKey (KeyCode.A)) 
		{
			rb2d.velocity = new Vector2 (-speed,0);
			transform.eulerAngles = new Vector2 (0, 180);
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			rb2d.velocity = new Vector2 (speed,0);
			transform.eulerAngles = new Vector2 (0, 0);
		}
		if (Input.GetKeyDown (KeyCode.LeftShift)) 
		{
			speed += 10;
		}
		if (Input.GetKeyUp (KeyCode.LeftShift)) 
		{
			speed -= 10;
		}

		//Bomb Activate
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			if (amountBomb > 0) 
			{
				BombActivate = true;
				Item2Activate = false;
				itemNow = 1;
			}
		}
		//Item2 Activate
		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			if (amountI2 > 0) 
			{
				Item2Activate = true;
				BombActivate = false;
				itemNow = 2;
			}
		}

		//Use Item
		if (Input.GetKeyDown(KeyCode.E)) 
		{
			//Bomb
			if (BombActivate = true && itemNow == 1) 
			{
				amountBomb -= 1;
			}
			//Item2
			if (Item2Activate = true && itemNow == 2) 
			{
				amountI2 -= 1;
			}
		}
		//Deactivate

		//Bomb
		if (amountBomb <= 0) 
		{
			BombActivate = false;
			amountBomb = 0;
		}
		//Item2
		if (amountI2 <= 0) 
		{
			Item2Activate = false;
			amountI2 = 0;
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Bomb") {
			Destroy (col.gameObject);
			amountBomb += 1;
		}
		if (col.tag == "Item2") {
			Destroy (col.gameObject);
			amountI2 += 1;
		}
	}
}
