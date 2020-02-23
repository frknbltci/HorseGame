using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent (typeof(AudioSource))]

public class playVideo : MonoBehaviour
{
	public MovieTexture movie;
	
   
    void Start()
    {
	
    }


    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space)&& movie.isPlaying)
		{
			movie.Pause();
		}
		else if (Input.GetKeyDown(KeyCode.Space) && !movie.isPlaying)
		{
			movie.Play();
		}
    }
}
