using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    [Header ("Camera Follow")]
	[SerializeField] Vector3 _Distancia_a_seguir=Vector3.zero;
	[SerializeField][Range (0.01f, 1.0f)]float smoothSpeed=0.1f;
	[SerializeField] [Range (0, 90.0f)]float RotX=45.0f, RotY=0;
    public GameObject Player;
    public string Tag_Seguir="player";

     void Awake() {
        if (Player == null)
            Player = GameObject.FindWithTag(Tag_Seguir);
            
    }
void Camera_follow(){
		Vector3 Seguir=Player.transform.position +_Distancia_a_seguir;
		Vector3 Smooth=Vector3.Lerp(Player.transform.position,Seguir,smoothSpeed);
		transform.position = Smooth;
		transform.eulerAngles = new Vector3(RotX,RotY,0);
		}
    void LateUpdate()
    {
        Camera_follow();
    }
}
