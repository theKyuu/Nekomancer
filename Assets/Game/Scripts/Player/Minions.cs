using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minions : MonoBehaviour {
    public int NumberOfMinions = 0;
    public GameObject[] CurrentMinions;
    public GameObject[] MinionPositions;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddMinion(GameObject minion)
    {
        if (NumberOfMinions < 4)
        {
            //minion.transform.SetParent(transform);
            CurrentMinions[NumberOfMinions] = minion;
            minion.GetComponent<FollowTarget>().SetTarget(MinionPositions[NumberOfMinions]);
            NumberOfMinions++;
        }
    }
}
