using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionScript : MonoBehaviour
{
        [SerializeField] private TextMeshPro textBox;
    // Want this script to handle COLLISION detection
    // When object impacts another, print text

    // First, collision

        private void OnCollisionEnter(Collision other)
        {
            Debug.Log("Raymond has fallen !");

            textBox.enabled = true;

            // when player press R, restart

            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            // This would destroy the ground instead
            //Destroy(collision.gameObject);
        }
}



