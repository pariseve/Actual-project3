using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paris
{
    public class TriggerScript : MonoBehaviour
    {
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

}
