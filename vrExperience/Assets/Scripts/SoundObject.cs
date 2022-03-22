using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundObject : MonoBehaviour
{
    bool colliding = false; //This Boolean checks to see if an object is being collided with

    void OnTriggerEnter(Collider collision) //Sets off when an object enters the attached object's Trigger
    {
        switch (collision.gameObject.tag) //Checks the Tag attached to the colliding GameObject
        {
            case "Stick": //Triggers if the Colliding GameObjects Tag is equal to 'Stick'
                if (colliding == false) //Checks to see if colliding is False, if it is, Trigger this code
                {
                    Debug.Log("Entering Collision");

                    colliding = true; //Sets colliding to True

                    gameObject.GetComponent<AudioSource>().Play(); //Plays the Sound Effect attached to the gameObject's AudioSource Component
                }

                break; //Braks from the Switch
        }
    }

    void OnTriggerExit(Collider collision) //Sets off when an object exits the attached object's Trigger
    {
        switch (collision.gameObject.tag) //Checks the Tag attached to the colliding GameObject
        {
            case "Stick": //Triggers if the Colliding GameObjects Tag is equal to 'Stick'
                if (colliding == true) //Checks to see if colliding is True, if it is, Trigger this code
                {
                    Debug.Log("Exiting Collision");

                    colliding = false; //Sets colliding to False
                }

                break; //Braks from the Switch
        }
    }
}
