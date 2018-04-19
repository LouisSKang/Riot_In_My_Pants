using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManaged : MonoBehaviour {

	// Use this for initialization
	void Start () {
		VB_DLL_Tutorial.MyClass obj = new VB_DLL_Tutorial.MyClass ();
		Debug.Log ("Add " + obj.ADD (1, 4));
	}

}
