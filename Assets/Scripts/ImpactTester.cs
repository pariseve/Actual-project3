using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImpactTester : MonoBehaviour

{
    // Want this script to handle COLLISION + TRIGGER detection
    // When object impacts another, print text

    // First, collision

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Oopsie I have collided !");

        // Destroy Cube + Sphere!!!

        Destroy(gameObject);

        // This would destroy the ground instead
        //Destroy(collision.gameObject);
    }

    // Now, trigger

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("I have been triggered !");

        // show text ig

        textBox.enabled = true;

        // Restart scene

        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    [SerializeField] private TextMeshPro textBox;
}
