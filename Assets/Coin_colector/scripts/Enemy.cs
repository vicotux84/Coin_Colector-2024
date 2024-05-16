using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    //public int Points=10;
    public Game_Manager GameManager;
    private GameObject Player;
    private Rigidbody rb;
    public string Tag_Player="Player";
    public Vector3 Posicion_inicial;


    private void Awake() {
      if (GameManager == null)
           GameManager = FindObjectOfType<Game_Manager>();
      if (Player == null)
            Player = GameObject.FindWithTag(Tag_Player);
    
    rb=Player.GetComponent<Rigidbody>();                  
    }

    void OnTriggerEnter(Collider other){
		if (other.tag == "Player"){
        GameManager.Lives();
        rb.velocity=Vector3.zero;
        Player.transform.position=Posicion_inicial;
  //Destroy (this.gameObject);      
    }
  }  
}
