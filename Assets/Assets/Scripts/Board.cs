using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Board 
{
    public struct Tile {
        public int owner; // 0 - empty, 1 - white, 2 - black
    }

    public Tile[,] tiles;
    

    // This constructor initializes a new empty board.
    public Board(int dims) 
    { 
        tiles = new Tile[dims, dims];
        for (int x = 0; x < dims; x++) {
            for (int y = 0; y < dims; y++) {
                tiles[x,y] = new Tile();
                tiles[x,y].owner = 0;
            }
        }
    }

    public int GetBoardXLen() 
    {
        return tiles.GetLength(0);
    }

    public int GetBoardYLen() 
    {
        return tiles.GetLength(1);
    }

    // Start is called before the first frame update
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
