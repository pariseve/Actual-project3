using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorKnob : MonoBehaviour
{
    [SerializeField] private TextMeshPro doorText;
    [SerializeField] private bool isPlayerCharacterNextToDoor = false;
    // when player character hits object, show tutorial

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNextToDoor)
        {
            Debug.Log("Door has opened.");
            doorText.enabled = false;

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
