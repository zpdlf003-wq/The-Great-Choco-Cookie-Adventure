using UnityEngine;

public class CookieCollisionSound : MonoBehaviour
{
    public AudioClip collisionSound;
    public float volume = 1.0f;
    public float soundCooldown = 0.1f;

    private float lastSoundTime = -999f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Cookie"))
        {
            if (Time.time - lastSoundTime < soundCooldown) return;

            lastSoundTime = Time.time;

            if (collisionSound != null)
            {
                AudioSource.PlayClipAtPoint(collisionSound, transform.position, volume);
            }
        }
    }
}