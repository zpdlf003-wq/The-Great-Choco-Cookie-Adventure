using UnityEngine;

public class CookieCrack : MonoBehaviour
{
    public Sprite NewÄíÅ°;       // ±âº» ÄíÅ°
    public Sprite NewÄíÅ°1;       // 30¹ø Ãæµ¹ ÈÄ ÀÌ¹ÌÁö
    public Sprite NewÄíÅ°2;       // 60¹ø Ãæµ¹ ÈÄ ÀÌ¹ÌÁö
    public AudioClip breakSound;      // ±úÁú ¶§ ¼Ò¸®

    public int firstCrackHit = 30;    // 1Â÷ ±İ
    public int secondCrackHit = 60;   // 2Â÷ ±İ
    public int breakHit = 90;         // ÆÄ±«

    public float hitCooldown = 0.2f;  // ¿¬¼Ó Ãæµ¹ ¹æÁö

    private int currentHitCount = 0;
    private bool isBroken = false;
    private float lastHitTime = -999f;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        if (sr != null && NewÄíÅ° != null)
        {
            sr.sprite = NewÄíÅ°;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBroken) return;

        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Cookie"))
        {
            if (Time.time - lastHitTime < hitCooldown) return;

            lastHitTime = Time.time;
            currentHitCount++;

            UpdateCrackImage();

            if (currentHitCount >= breakHit)
            {
                BreakCookie();
            }
        }
    }

    private void UpdateCrackImage()
    {
        if (sr == null) return;

        if (currentHitCount >= secondCrackHit)
        {
            if (NewÄíÅ°2 != null)
                sr.sprite = NewÄíÅ°2;
        }
        else if (currentHitCount >= firstCrackHit)
        {
            if (NewÄíÅ°1 != null)
                sr.sprite = NewÄíÅ°1;
        }
        else
        {
            if (NewÄíÅ° != null)
                sr.sprite = NewÄíÅ°;
        }
    }

    private void BreakCookie()
    {
        if (isBroken) return;

        isBroken = true;

        if (breakSound != null)
        {
            AudioSource.PlayClipAtPoint(breakSound, transform.position);
        }

        Destroy(gameObject);
    }
}