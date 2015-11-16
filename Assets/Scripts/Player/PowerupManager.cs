using UnityEngine;
using System.Collections.Generic;

public class PowerupManager : MonoBehaviour {
    BulletsDict Powers = new BulletsDict ();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

class BulletsDict : Dictionary<string, AbstractBullets> { }
