using UnityEngine;
using System.Collections;

public class TriggerSound : MonoBehaviour {
  public AudioSource audio;

  void Start() {
    audio = GetComponent<AudioSource> ();
  }

  void OnTriggerEnter(Collider other) { 
   audio.Play ();
  }
 } 