using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetsFromAbs : MonoBehaviour {
	public AssetBundle Abs;
	public string Name;
	public GameObject Child;
	public bool IsLoaded = false;
	public string SystemPlatform;



	void Start () {
		if (Application.platform == RuntimePlatform.WindowsEditor)
			SystemPlatform = "Win";
		if (Application.platform == RuntimePlatform.WindowsPlayer)
			SystemPlatform = "Win";
		if (Application.platform == RuntimePlatform.Android)
			SystemPlatform = "Android";
		if (Application.platform == RuntimePlatform.IPhonePlayer)
			SystemPlatform = "ios";
		if (Application.platform == RuntimePlatform.OSXEditor)
			SystemPlatform = "ios";
	}




	void Process()
	{

		Child = null;
		IsLoaded = false;
		Child = Instantiate(Abs.LoadAsset (Name)as GameObject);
		if (Child != null) {
			IsLoaded = true;
		}
		Debug.Log ("執行從ABs打撈Asset");
	}

}