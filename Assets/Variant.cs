using UnityEngine;
using System.Collections;

public class Variant : MonoBehaviour {
	protected string variantName;

	public string VariantName{
		get{
			return variantName;
		}
	}
	public string abilityName;

	public virtual void InvokeAbility(){

	}

}
