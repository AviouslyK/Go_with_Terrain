using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/*
    Game is a class describing the game state. It keeps track of the board state and 
    implements player moves
*/

public class Game : MonoBehaviour
{
    // references
    public GameObject stone_obj;

    public GameObject controller;
  

    private GameObject[] blackStones = new GameObject[41]; // holds black's stones
    private GameObject[] whiteStones = new GameObject[41]; // holds white's stones

    public int boardSize = 9; // start with 9x9

    public Board gameBoard; 

    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Start");


        // Create the Board
        gameBoard = new Board(9);
        Debug.Log("gameboard is " + gameBoard.GetBoardXLen() + " by " + gameBoard.GetBoardXLen());


        blackStones = new GameObject[] {
            Create(1,2,2)
        };
        /*
        // Create all black and white stones and put them on the side of the board 
        for (int i = 0; i < blackStones.Length; i++)
        {
            whiteStones[i] = Create(1,6,6);
            blackStones[i] = Create(2,6,6);
        }
        */       
    }

    // All Stones are created at the beginning of the game
    public GameObject Create(int col, int x, int y)
    {
        GameObject obj = Instantiate(stone_obj, new Vector3(0,0,-2), Quaternion.identity);
        Stone p = obj.GetComponent<Stone>();
        p.xBoard = x;
        p.yBoard = y;
        p.color = col;
        p.Activate(col);  // put on correct sprite
        p.SetCoords();
    
        return obj;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
