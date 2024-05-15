using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GM_sound : MonoBehaviour{
    public AudioMixer audiomixer;
    public void FxSound(float Fxvolumen){
       audiomixer.SetFloat("Fxvolumen",Fxvolumen) ;
    }
    public void MusicSound(float Musicvolumen){
       audiomixer.SetFloat("Soundvolumen",Musicvolumen) ;
    }
}
