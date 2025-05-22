using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundAudioSource;
    [SerializeField] private AudioSource effectAudioSource;

    [SerializeField] private AudioClip backGroundClip;
    [SerializeField] private AudioClip jumpClip;
    [SerializeField] private AudioClip coinClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayBackgroundMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayBackgroundMusic()
    {
        backgroundAudioSource.clip = backGroundClip;
        backgroundAudioSource.Play();
    }
    public void PlayJumpSound()
    {
        effectAudioSource.PlayOneShot(jumpClip);   
    }
    public void PlayCoinSound()
    {
        effectAudioSource.PlayOneShot(coinClip);
    }
}

