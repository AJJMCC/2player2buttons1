using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource SFX;
    public AudioSource MusicPlayer;

    public AudioClip[] Music;

    public AudioClip ButtonBoop;
    public AudioClip Shoot;
    public AudioClip ShipHit;
    public AudioClip gameover;

    // Use this for initialization
    void Start()
    {
        PlayNextSong();
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlayNextSong()
    {
        MusicPlayer.clip = Music[Random.Range(0, Music.Length)];
        MusicPlayer.Play();
        Invoke("PlayNextSong", MusicPlayer.clip.length);
    }

    public void CLicked()
    {
        SFX.PlayOneShot(ButtonBoop);

    }

    public void FIred()
    {
        SFX.PlayOneShot(Shoot);
    }

    public void Death()
    {
        SFX.PlayOneShot(ShipHit);
    }

    public void End()
    {
        SFX.PlayOneShot(gameover);
    }

    public void FadeOut()
    {
        StartCoroutine(AudioFadeScript.FadeOut(MusicPlayer, 0.5f));
    }


    public static class AudioFadeScript
    {
        public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
        {
            float startVolume = audioSource.volume;

            while (audioSource.volume > 0)
            {
                audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

                yield return null;
            }

            audioSource.Stop();
            audioSource.volume = startVolume;
        }
    }
}
