using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUnManaged : MonoBehaviour {
	public int size = 512;
	public Text plugin;
	public Text local;

	// Use this for initialization
	void Start () {
		
		//ArrayFillTest(); 

	}

	public void ArrayFillTest() { 
		var start = Time.realtimeSinceStartup; 
		int[,] tab = Wrapper.fillArray(size);
		plugin.text = (Time.realtimeSinceStartup - start).ToString ("f6") + " secs";
		Debug.Log( plugin.text); 
		start = Time.realtimeSinceStartup; 
		int[,] array = new int[size,size]; 
		for(int i = 0; i < size; i++) { 
			for(int j = 0; j < size; j++) { 
				array[i,j] = i * size + j; 
			} 
		}
		local.text = (Time.realtimeSinceStartup - start).ToString ("f6") + " secs";
		Debug.Log( local.text); 
	} 

}
