using UnityEngine;

public class SoundControl : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (audioSource != null)
            {
                audioSource.Stop();
            }
        }
    }
}