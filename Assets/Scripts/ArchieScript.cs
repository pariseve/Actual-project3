using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArchieScript : MonoBehaviour
{
    [SerializeField] private GameObject archieNPC;
    [SerializeField] private bool isPlayerNextToArchie = false;
    [SerializeField] private TextMeshPro archieText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerNextToArchie)

            Debug.Log("Archie greets Raymond.");
            archieText.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Raymond approached Archie.");
        if (other.CompareTag("Player"))
        {
            isPlayerNextToArchie = true;
        }
    }
}
