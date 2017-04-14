using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanCache : MonoBehaviour {

	void ProcessCleanCache()
	{

		Caching.CleanCache();
		Debug.Log ("清除快取");

	}
}
