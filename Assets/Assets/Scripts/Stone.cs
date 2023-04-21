using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Has this stone been moved onto the board already?
    private bool isDeployed = false;

    public bool getStoneDeployment(){ return isDeployed; }
    public void setStoneDeployment(bool status) { isDeployed = status; } 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // When you click on a stone
    public void OnMouseUp()
    {   
        //if (!getStoneDeployment())
        //{
            // Turn on MovePlates
        //}

        // Once deployed, cannot be moved again
        setStoneDeployment(true);
    }
}
