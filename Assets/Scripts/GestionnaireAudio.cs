using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireAudio : MonoBehaviour
{
    private AudioSource musique;

    private void Start()
    {
        musique = GetComponent<AudioSource>();
        musique.volume = 0;
    }

    public void AjusteVolumeMusique(float volume)
    {
        Debug.Log("Volume musique: " + volume);

        musique.volume = volume;
    }
    public void AjusteVolumeEffets(float volume)
    {
        Debug.Log("Volume effets: " + volume);
    }


}
