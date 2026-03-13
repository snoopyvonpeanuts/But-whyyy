using UnityEngine;

public class CatFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;

    void Update()
    {
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.Instance.GameOver();
        }
    }
}