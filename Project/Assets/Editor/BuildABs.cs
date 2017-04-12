// Create an AssetBundle for Android.
using UnityEngine;
using UnityEditor;

public class BuildAssetBundlesExample : MonoBehaviour
{
	[MenuItem( "Assets/Build Asset Bundles/Android" )]
	static void BuildAssetAndroid( )
	{
		// 輸入打包路徑
		BuildPipeline.BuildAssetBundles( "AssetBundles/Android", BuildAssetBundleOptions.None, BuildTarget.Android );
	}

	[MenuItem( "Assets/Build Asset Bundles/Windows" )]
	static void BuildAssetWindows( )
		{
		// 輸入打包路徑
		BuildPipeline.BuildAssetBundles( "AssetBundles/Windows", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows );
	}
}