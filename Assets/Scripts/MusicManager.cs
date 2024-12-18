using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Classe respons�vel por controlar qualquer tipo de �udio
    private AudioSource audioSource;

    // AudioClip � o arquivo de audio que ser� executado
    public AudioClip levelMuisc;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(AudioClip music)
    {
        // Define o som que que ir� ser reproduzido
        audioSource.clip = music;

        // Reproduz o som
        audioSource.Play();
    }

}
