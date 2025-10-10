using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    string currentSong = "Use Me Up (Angel's Order)";
    float volume = 1.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.P)){
            PlaySong(currentSong);
        }
        if (Input.GetKey(KeyCode.V)){
            SetVolume(volume);
        }
        if (Input.GetKey(KeyCode.S))
        {
            StopSong(currentSong);
        }
    }

    void PlaySong(string songName)
    {
        Debug.Log("Playing Song:" + songName);
    }
    void StopSong(string currentSong)
    {
        Debug.Log("Song Stopped");
    }
    void SetVolume(float volume)
    {
        volume ++;
        Debug.Log("Volume:" + volume);
    }
}
