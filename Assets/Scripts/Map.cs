using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject oceanTile;
    public GameObject hitTile;
    public GameObject missTile;

    public int size;
    private Tile[,] maps;

	// Use this for initialization
	void Start () {
        createMap();
        displayMap();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void createMap()
    {
        maps = new Tile[size, size];
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                if (Random.Range(0, 100) > 80)
                {
                    Tile t = new Tile();
                    t.tileType = TileType.Hit;
                    maps[x, y] = t;
                }
                else
                {
                    Tile t = new Tile();
                    t.tileType = TileType.Ocean;
                    maps[x, y] = t;
                }

            }
        }
    }

    void displayMap()
    {
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                switch (maps[x, y].tileType)
                {
                    case TileType.Ocean:
                        Instantiate(oceanTile, new Vector3(x, 0, y), Quaternion.identity);
                        break;
                    case TileType.Hit:
                        Instantiate(hitTile, new Vector3(x, 0, y), Quaternion.identity);
                        break;
                    case TileType.Miss:
                        Instantiate(missTile, new Vector3(x, 0, y), Quaternion.identity);
                        break;
                }

            }
        }
    }
}
