#region Previas
using UnityEngine; 
using System.Collections; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
#endregion
public class pause_manager : MonoBehaviour {
    public Canvas canvasPausa;
	#region Unity
	void Start(){
	canvasPausa.enabled = false;
	Time.timeScale = 1;
	Cursor.visible = false;
	}
	#endregion
	#region quality	
	public void antiAliasing_Quality (int Level){
	QualitySettings.antiAliasing = Level;
	}
	public void Vsync(int Vsync){
	QualitySettings.vSyncCount = Vsync;
	}
	public void fullScreen(){
	Screen.fullScreen = !Screen.fullScreen;
	}
	#endregion
	#region Resolutions
	public void Resolution480p (){
		 Screen.SetResolution(848, 480, false);
		}
	public void Resolution600p (){
		 Screen.SetResolution(1024, 600, false);
		}	
		public void Resolution720p (){
		 Screen.SetResolution(1280, 720, false);
		}
		public void Resolution1080p (){
		 Screen.SetResolution(1920, 1080, false);
		}
	void Update(){
		if (Input.GetButtonDown ("Cancel")){
			Pause();}
			}
	#endregion
	#region Pause		
    public void Pause(){
		Cursor.visible = !Cursor.visible;
        canvasPausa.enabled = !canvasPausa.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1: 0;
		}
	#endregion
	#region others	
	
	public void scene(string name){
	Time.timeScale=1;	 
	SceneManager.LoadScene (name);
	}
			
	public void Quit(){
     #if UNITY_EDITOR 
    EditorApplication.isPlaying = false;
    #else
    Application.Quit();
	#endif
	}
	#endregion
}