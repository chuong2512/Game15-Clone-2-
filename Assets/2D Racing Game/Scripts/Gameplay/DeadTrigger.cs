using UnityEngine;
using System.Collections;

public class DeadTrigger : MonoBehaviour
{
    GameManager manager;

    public bool enter;

    void Start()
    {
        manager = GameObject.FindObjectOfType<GameManager>();
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Ground")
        {
            manager.isDead = false;
            enter = false;
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ground")
        {
            manager.isDead = true;
            manager.StartDead();
            enter = true;
        }
    }
}