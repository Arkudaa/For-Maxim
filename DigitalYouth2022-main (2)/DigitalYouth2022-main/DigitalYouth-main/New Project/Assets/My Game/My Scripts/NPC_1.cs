using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0","HELLO TRAVELLER!", "1");
		Speech.AddDialogue("1", "WELCOME TO OUR PLANET", "2");
		Speech.AddDialogue("2", "FIND POWERUP AND YOU CAN JUMP HIGHER", "3");
		Speech.AddDialogue("3", "THEN GO TO NEXT ISLAND");
	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
		Speech.SetDialogue("0");
	}
}