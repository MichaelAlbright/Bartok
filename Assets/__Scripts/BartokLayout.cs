using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class SlotDef
{
	public float x;
	public float y;
	public bool faceUp=false;
	public string layerName="Default";
	public int layerID = 0;
	public int id;
	public List<int> hiddenBy = new List<int> ();
	public float rot;
	public string type = "slot";
	public Vector2 stagger;
	public int player;
	public Vector3 pos;
}

public class BartokLayout : MonoBehaviour {
	
}
