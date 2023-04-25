using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/*
    MovePlate is a class containing the MovePlate objects which appear on legal areas where a player may 
    place a stone. 
*/

public class MovePlate : MonoBehaviour
{

    public GameObject controller;
    
    // Move plates need to have reference back to stone that wants to move
    GameObject reference = null; 


    // Move Plate Coordinates
    public int plateX {get; set;}
    public int plateY {get; set;}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetReference(GameObject obj) { reference = obj; }

    // activates when you click on the MovePlate
    public void OnMouseUp()
    {
        // Move Piece to MovePlate location
        // Get Controller 
        controller = GameObject.FindGameObjectWithTag("GameController");
    }
}
