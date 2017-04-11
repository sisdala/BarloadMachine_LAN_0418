using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour {
	public AssetBundle Abs;
	public string Name;
	public Object Child;


	void gogogo()
	{
		Child = Instantiate (Abs.LoadAsset (Name));
		Debug.Log ("5555555555");
	}
}