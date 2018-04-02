using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {
	void OnTriggerEnter (Collider collider) {
		GM.instance.LostLife ();
	}
}
