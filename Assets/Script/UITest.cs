using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UITest : MonoBehaviour {
	//itemText
	public Text Item1Text;
	public Text Item2Text;

	//itemNow Text
	public Text ItemNowText;
	private int itemNow;

	//item1
	private bool item1_activate;
	private int amountItem1;

	//item2
	private bool item2_activate;
	private int amountItem2;

	void Start ()
	{
		ItemNowText.text = "Empty";
		Item1Text.text = "Bomb = 0";
		Item2Text.text = "Item2 = 0";
	}

	void Update ()
	{
		//Item Text

		//Bomb
		item1_activate = PlayerCTrl.BombActivate;
		if ((Input.GetKeyDown(KeyCode.Alpha1))) 
		{
			ItemNowText.text = "Bomb";
		}
		//Item2
		item2_activate = PlayerCTrl.Item2Activate;
		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			ItemNowText.text = "Item2";
		}

		//Item Amout Text

		//Bomb
		amountItem1 = PlayerCTrl.amountBomb;
		Item1Text.text = "Bomb = " + amountItem1;

		//Item2
		amountItem2 = PlayerCTrl.amountI2;
		Item2Text.text = "Item2 = " + amountItem2;
	}
}
