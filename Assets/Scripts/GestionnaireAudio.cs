using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class GestionnaireAudio : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer; 
    private float volume;
    
    [SerializeField] private Slider sliderVolumeMusique;
    [SerializeField] private Slider sliderVolumeFx;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //audioMixer.SetFloat("MusiqueVolume", -20f);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("MusiqueVolume", ConvertToLogarithmique(volume));
        
    }
    public void AjusteVolumeFx(float volume){
        audioMixer.SetFloat("FxVolume", ConvertToLogarithmique(volume));
        audioSource.Play();
    }
    private float ConvertToLogarithmique(float volume){
        
        if(volume==0){
            return -80;
        }
        else{
            return Mathf.Log10(volume)*20;
        }
    }
}
