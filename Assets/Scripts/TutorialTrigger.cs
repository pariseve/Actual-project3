using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    [SerializeField] private TextMeshPro tutorialText;
    // when player character hits object, show tutorial
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tutorial has been triggered.");

        if (other.CompareTag("Player"))
        {
            tutorialText.enabled = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        tutorialText.enabled = false;
    }
}
