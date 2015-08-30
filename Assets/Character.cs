using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Character : MonoBehaviour {
	private int curActions;
	private int bloodThreshold = 15;
	private int fleshThreshold = 15;
	private int boneThreshold = 15;
	public Variant variant;
	public List<Trait> traits = new List<Trait>();
	public int maxActions;
	public List<Card> bloodStack = new List<Card>();
	public List<Card> fleshStack = new List<Card>();
	public List<Card> boneStack = new List<Card>();

	public int CurActions{
		get{
			return curActions;
		}
		set{
			curActions = value;
		}
	}
	public int BloodThreshold{
		get{
			return bloodThreshold;
		}
	}
	public int FleshThreshold{
			get{
				return fleshThreshold;
			}
		}
	public int BoneThreshold{
		get{
			return boneThreshold;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
}
