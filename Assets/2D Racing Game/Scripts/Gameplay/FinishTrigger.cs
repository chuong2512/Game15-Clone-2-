using UnityEngine;
using System.Collections;

public class FinishTrigger : MonoBehaviour
{
    // Use this for initialization
    public GameObject finishMenu;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            finishMenu.SetActive(true);
        }
    }
}