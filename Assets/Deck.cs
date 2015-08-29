using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck <T> where T : class{

	private List<T> items = new List<T>();
	public T Item{
		get{
			return items[0];
		}
	}
	

	public void AddItem(T newItem){
		items.Add (newItem);
	}

	public void Shuffle(){
		for(int i = 0; i <= items.Count; i++){
			T temp = items[i];
			int randomIndex = Random.Range(i, items.Count);
			items[i] = items[randomIndex];
			items[randomIndex] = temp;
		}
	}

	public T Draw(){
		if(items.Count > 0){
			T drawnItem = Item;
			items.RemoveAt(0);
			return drawnItem;
		}
		else{
			Debug.LogWarning("No items in deck");
			return null;
		}

	}

	public T Search(T seachedItem){
		for(int i = 0; i <= items.Count; i++){
			if(items[i] == seachedItem){
				return items[i];
			}
		}
		return null;
	}

	public int Count(){
		return items.Count;
	}
	
}
