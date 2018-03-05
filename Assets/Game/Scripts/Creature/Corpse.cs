using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Creature))]
[RequireComponent(typeof(ActionListener))]
public class Corpse : MonoBehaviour {
    private Creature ThisCreature;
    private Player player;
    private ActionListener Listener;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
        ThisCreature = GetComponent<Creature>();
        Listener = GetComponent<ActionListener>();
	}
	
    public void Action()
    {
        GameObject minion = Instantiate(ThisCreature.Type.RelatedMinion);
        minion.transform.position = transform.position;
        minion.GetComponent<Creature>().SetLevel(ThisCreature.CurrentLevel);
        player.GetComponent<Minions>().AddMinion(minion);
        Destroy(gameObject);
    }

	// Update is called once per frame
	void Update () {
        if (Listener.activated)
        {
            Action();
            Listener.activated = false;
        }
	}
}
