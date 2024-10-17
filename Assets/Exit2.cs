using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject gemGreen;
    public GameObject Level1A_BG;
    public string teleporterDestination;

    private void OnTriggerEnter(Collider other)
    {
        if (gemGreen.activeInHierarchy == false)
        {
            Level1A_BG.GetComponent<GameManager>().TeleportOpen(teleporterDestination);
        }

    }
}
