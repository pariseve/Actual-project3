using Paris;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] private TextMeshPro textBox;
   
    [SerializeField] private CharacterController controller;
   
    [SerializeField] GameObject playerCharacter;

    private bool showTextBox = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Raymond has fallen :(");
            showTextBox = true;
        }
    }

    private void Update()
    {
        if (showTextBox)
        {
            textBox.enabled = true;

            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("Respawned");
                if (controller != null)
                {
                    controller.enabled = false;
                }
                Vector3 teleportPosition = new Vector3(0.13f, 22.15f, -24.31f);
                playerCharacter.transform.position = teleportPosition;
                textBox.enabled = false;
                controller.enabled = true;
                showTextBox = false;
            }
        }
    }
}
    
    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Raymond has fallen :(");

    //    // show text ig

    //    textBox.enabled = true;

    //    // Restart sceen
       
    //}

    //private void Update()
    //{
    //    {
    //    if (Input.GetKeyDown(KeyCode.R))
    //    {

    //        Debug.Log("Respawned");
    //        if(controller != null)
    //        {
    //            controller.enabled = false;
    //        }
    //        Vector3 teleportPosition = new Vector3(0.13f, 22.15f, -24.31f);
    //        playerCharacter.transform.position = teleportPosition;
    //        textBox.enabled = false;
    //        controller.enabled = true;
    //    }
    //}
    //}
    
//}
 //public class TriggerScript : MonoBehaviour
  //  {
        // Now, trigger

    //    private void OnTriggerEnter(Collider collider)
       // {
         //   Debug.Log("Raymond has fallen :(");

            // show text ig

        //    textBox.enabled = true;

            // Restart scene

        //    if (Input.GetKeyDown(KeyCode.R))
        //    {
        //        SceneManager.LoadScene("My_Game");
        //    }

            
      //  }

      //  [SerializeField] private TextMeshPro textBox;
  //  }