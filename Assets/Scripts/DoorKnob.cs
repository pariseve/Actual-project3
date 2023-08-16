using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorKnob : MonoBehaviour
{
    [SerializeField] private TextMeshPro doorText;
    [SerializeField] private bool isPlayerCharacterNextToDoor = false;
    [SerializeField] GameObject actualDoor;
    [SerializeField] private bool isDoorOpen = false;
    // when player character hits object, show tutorial

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNextToDoor)
        {
            if (!isDoorOpen)
            {
                Debug.Log("Door has opened.");
                doorText.enabled = false;
                //makes door rotate on y axis
                actualDoor.transform.Rotate(Vector3.up, 90f);
                isDoorOpen = true;
            }
            else
            {
                Debug.Log("Door has closed.");
                doorText.enabled = false;
                actualDoor.transform.Rotate(Vector3.up, -90f);
                isDoorOpen = false;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Door Text has been triggered.");

        if (other.CompareTag("Player"))
        {
            //show text
            doorText.enabled = true;
            isPlayerCharacterNextToDoor = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                Vector3 transformRotation = new Vector3(0f, 90f, 0f);
                doorText.enabled = false;
            }
        }

    }


}
