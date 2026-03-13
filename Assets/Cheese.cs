using UnityEngine;

public class CheeseCollect : MonoBehaviour
{
    public AudioClip collectSound;
    private AudioSource audioSource;

    public int scoreValue = 1;

    void Start()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(scoreValue);
            audioSource.PlayOneShot(collectSound);
            Destroy(gameObject);
        }
    }
}