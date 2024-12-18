using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Classe responsável por controlar qualquer tipo de áudio
    private AudioSource audioSource;

    // AudioClip é o arquivo de audio que será executado
    public AudioClip levelMuisc;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(AudioClip music)
    {
        // Define o som que que irá ser reproduzido
        audioSource.clip = music;

        // Reproduz o som
        audioSource.Play();
    }

}
