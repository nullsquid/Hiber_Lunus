using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class TurnVariables : NetworkBehaviour {
	public int actionCount;
	// Use this for initialization

	[Command]
	void CmdUseAction(){

	}

}
