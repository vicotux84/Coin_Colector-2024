using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    
    [Range(1.0f, 200.0f)][SerializeField]private float speed=10.0f;
    public Vector3 Posicion_inicial;
    private float MovX, MovY;
    private Rigidbody rb;
    
    private void Awake() {
        rb=GetComponent<Rigidbody>();
        Cursor.visible = false;
        transform.position=Posicion_inicial;
        }

    void FixedUpdate(){
        MovX=Input.GetAxis("Horizontal");
        MovY=Input.GetAxis("Vertical");
        Debug.Log(MovX);
        Debug.Log(MovY);
        OnMove(MovX,MovY);
    }
    void OnMove(float MovY, float MovX){
        Vector3 moveVector=new Vector3(MovY,0,MovX);
        rb.AddForce(moveVector*speed);
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Enemy"){
			Game_Manager.estancia.Lives();
			rb.velocity=Vector3.zero;
			transform.position=Posicion_inicial;
			}
		}	
}
