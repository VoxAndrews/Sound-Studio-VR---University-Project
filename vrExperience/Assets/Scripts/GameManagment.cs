using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagment : MonoBehaviour
{
    [SerializeField]
    GameObject[] vivePointers =  new GameObject[2]; //The GameObject for the Vive pointer
    [SerializeField]
    GameObject[] viveLines = new GameObject[2]; //The GameObject for the Vive pointer lines

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DisableGuides", 0.1f); //Disables the guides after a set amount of time (Without this, Start could not see them in time)
    }

    void DisableGuides() //This function disables the default Vive Guides as they would be distracting and detract from the games aesthetics
    {
        vivePointers[0].GetComponent<MeshRenderer>().enabled = false; //Turns the MeshRenderer for the Vive Pointer off
        vivePointers[1].GetComponent<MeshRenderer>().enabled = false; //Turns the MeshRenderer for the Vive Pointer off

        viveLines[0].SetActive(false); //Sets the Line drawn by the Vive Controls to be Inactive
        viveLines[1].SetActive(false); //Sets the Line drawn by the Vive Controls to be Inactive
    }
}
