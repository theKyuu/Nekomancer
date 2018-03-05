using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Creature))]
public class Enemy : MonoBehaviour {
    private Creature ThisCreature;

	// Use this for initialization
	void Start () {
        ThisCreature = GetComponent<Creature>();
	}
	
	// Update is called once per frame
	void Update () {
		if (ThisCreature.CurrentHealth < 1)
        {
            GameObject corpse = Instantiate(ThisCreature.Type.RelatedCorpse);
            corpse.transform.position = transform.position;
            corpse.GetComponent<Creature>().SetLevel(ThisCreature.CurrentLevel);
            Destroy(gameObject);
        }
	}
}
