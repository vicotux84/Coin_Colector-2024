using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class Menu : MonoBehaviour
{
	public AudioSource Audio;
	public AudioClip Button;
	private void Awake() {
		cursorfalse();
	}
	public void Quit(){
        #if UNITY_EDITOR 
        EditorApplication.isPlaying = false;
        #else
        Application.Quit();
		#endif
		}
		
	public void cursorF(){
		Application.OpenURL("http://www.youtube.com/eltuga24");
	}
	public void buttonsound() {
		Audio.clip =Button;
		Audio.Play();
		cursortrue();
	}
		
		public void LevelSelect(string name){ 
		Game_Manager.estancia.Reset_game();
		Game_Manager.estancia.music();
		SceneManager.LoadScene (name);
		}

	public void cursortrue(){
		Cursor.visible = true;
	}
	public void cursorfalse(){
		Cursor.visible = false;
	}		

	public void scene(string name){ 
		SceneManager.LoadScene (name);
		Game_Manager.estancia.music();
		}
	public void Vsync(int Vsync){
		QualitySettings.vSyncCount = Vsync;}
}
