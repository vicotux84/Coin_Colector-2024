using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{
    public int Points=10;
    public Game_Manager GameManager;

    private void Awake() {
      if (GameManager == null)
           GameManager = FindObjectOfType<Game_Manager>();;
      GameManager.MaxScore+= Points;      
    }

    void OnTriggerEnter(Collider other){
		if (other.tag == "Player"){
    Destroy (this.gameObject);
        GameManager.Puntacion(Points);
    }
  }  
}
