using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour {
	public AssetBundle Abs;
	public string Name;
	public GameObject Child;


	void Process()
	{
		Child = Instantiate (Abs.LoadAsset (Name))as GameObject;
		Debug.Log ("5555555555");
	}
}