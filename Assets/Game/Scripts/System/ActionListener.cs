using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionListener : MonoBehaviour {
    private Player player;
    public bool activated = false;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision = player.GetComponent<BoxCollider2D>())
        {
            player.SetInteract(this);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision = player.GetComponent<BoxCollider2D>())
        {
            if (player.CurrentInteract == this)
            {
                player.SetInteract(null);
            }
        }
    }

    public void Activate()
    {
        activated = true;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
