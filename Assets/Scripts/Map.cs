using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject oceanTile;
    public int size;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for(int x =0; x<size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                Instantiate(oceanTile, new Vector3(x, 0, y), Quaternion.identity);
            }
        }
	}
}
