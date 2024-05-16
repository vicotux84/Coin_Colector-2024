using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    
    [Range(1.0f, 200.0f)]public float speed=10.0f;
    public string Horizontal= "Horizontal", Vertical="Vertical";
    private Rigidbody rb;
    private float MovX, MovY;

    
    private void Awake() {
        rb=GetComponent<Rigidbody>();
        Cursor.visible = false;
        }

    void FixedUpdate(){
        MovX=Input.GetAxis(Horizontal);
        MovY=Input.GetAxis(Vertical);
        OnMove(MovX,MovY);
    }
    void OnMove(float MovY, float MovX){
        Vector3 moveVector=new Vector3(MovY,0,MovX);
        rb.AddForce(moveVector*speed);
    }
    	
}
