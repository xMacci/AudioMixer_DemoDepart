using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;

    [SerializeField]
    private AudioClip sonFxTest;

    [SerializeField]
    private Slider glissiereVolumeMusique;
    
    [SerializeField]
    private Slider glissiereVolumeEffets;

    private AudioSource audioSource;


    private void Start()
    {

        audioSource = GetComponent<AudioSource>();

        float volume;

        //Passage de parametre par référence
        audioMixer.GetFloat("VolumeMusique", out volume);
        glissiereVolumeMusique.value = volume;


        audioMixer.GetFloat("VolumeEffets", out volume);
        glissiereVolumeEffets.value = volume;

    }


    // Méthode appelée par le slider du volume musique
    public void AjusteVolumeMusique(float volume)
    {
        Debug.Log("Volume musique: " + volume);

        audioMixer.SetFloat("VolumeMusique", volume);

    }
    public void AjusteVolumeEffets(float volume)
    {
        Debug.Log("Volume effets: " + volume);

        audioMixer.SetFloat("VolumeEffets", volume);

    }


    public void TestVolumeEffet()
    {
        audioSource.PlayOneShot(sonFxTest);
    }


}
