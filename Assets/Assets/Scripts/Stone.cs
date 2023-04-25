using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Stone is a class describing the playing pieces - stones. 
    It describes their movement through player interaction
*/

public class Stone : MonoBehaviour
{

    // References 
    public Sprite p1, p2; // p1 = white stone, p2 = black stone
    public GameObject controller;
    public GameObject movePlate; // where you can move your piece

    // Has this stone been moved onto the board already?
    private bool isDeployed = false;

    public bool getStoneDeployment(){ return isDeployed; }
    public void setStoneDeployment(bool status) { isDeployed = status; } 

    public int xBoard { get; set; }
    public int yBoard { get; set; }
    public int color { get; set;} // 1 = white, 2 = black

    // Set Position Function

    // Called when you create a stone. Attaches the correct Sprite
    public void Activate(int col)
    {
        controller = GameObject.FindGameObjectWithTag("GameController");
        if (col == 1)
        {
            this.GetComponent<Stone>().GetComponent<SpriteRenderer>().sprite = p1;
        }
        else if (col == 2)
        {
            this.GetComponent<Stone>().GetComponent<SpriteRenderer>().sprite = p2;
        }
        else
        {
            Debug.Log("ERROR: Invalid color assigned to stone. Must be 0 or 1. It was " + col);
        }
    }

    // keeps track of global coords, based on board coords
    public void SetCoords(){ 
        float x = xBoard;
        float y = yBoard;

        // found through trial and error
        //x *= 1.25f;
        //y *= 1.25f;

        x += 0.5f;
        y += -0.5f;

        this.transform.position = new Vector3(x,y,-1.0f); // set z = -1 so in front of board
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }   

    // When you click on a stone
    public void OnMouseUp()
    {   
        if (!getStoneDeployment())
        {
            // Turn on MovePlates
            SpawnMovePlate(0,0);
        }

        // Once deployed, cannot be moved again
        setStoneDeployment(true);
    }

    public void SpawnMovePlate(int matrixX, int matrixY)
    {
        float x = matrixX;
        float y = matrixY;
        
        // found through trial and error
        //x *= 1.25f;
        //y *= 1.25f;

        //x += -4.4f;
        //y += -4.4f;

        GameObject mp = Instantiate(movePlate, new Vector3(x,y,-3.0f), Quaternion.identity); // for displaying on screen in unity
        MovePlate mpScript = mp.GetComponent<MovePlate>();
        mpScript.SetReference(gameObject);
        mpScript.plateX = matrixX;
        mpScript.plateY = matrixY; // for us to keep track
    }
}
