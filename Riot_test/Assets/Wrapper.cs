using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Wrapper
{
	#if UNITY_STANDALONE
	const string dll = "LowLevelPlugin";
	#elif UNITY_STANDALONE_OSX
	const string dll = "LowLevelPlugin";
	#elif UNITY_IOS
	const string dll = "__Internal";
	#elif UNITY_ANDROID
	const string dll = "LowLevelPlugin";
	#endif

	[DllImport(dll)]
	public static extern int [,] fillArray(int size);


}
