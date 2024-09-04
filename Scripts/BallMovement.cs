using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private int speed = 30;
    private bool movingRight;
    private bool movingUp;
    public AudioClip sound1;
    AudioSource audioSource;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movingRight = (Random.value > 0.5);
        movingUp = (Random.value > 0.5);
        StartCoroutine(StartWait());
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Goal1")
        {
            //SoundManager.Instance.PlaySoundEffect(SoundManager.Instance.SE_Reverbe);
            Debug.Log("Player 2 scored");
            rb.velocity = Vector2.zero;
            GlobalVariables.player2Score++;
            SceneManager.LoadScene("GameScene_240905");
        }
        if (col.gameObject.tag == "Goal2")
        {
            //SoundManager.Instance.PlaySoundEffect(SoundManager.Instance.SE_Reverbe);
            Debug.Log("Player 1 scored");
            rb.velocity = Vector2.zero;
            GlobalVariables.player1Score++;
            SceneManager.LoadScene("GameScene_240905");
        }
        if (col.gameObject.tag == "Wall")
        {
           Debug.Log("WallHit");
           audioSource.PlayOneShot(sound1);
        }


    }

    private IEnumerator StartWait()
    {
        yield return new WaitForSecondsRealtime(1);

        if (movingRight)
        {
            if (movingUp)
            {
                rb.velocity = new Vector2(Random.Range(1f, 2f), 1f).normalized * speed;
            }
            else
            {
                rb.velocity = new Vector2(Random.Range(1f, 2f), -1f).normalized * speed;
            }
        }
        else
        {
            if (movingUp)
            {
                rb.velocity = new Vector2(Random.Range(-1f, -2f), 1f).normalized * speed;
            }
            else
            {
                rb.velocity = new Vector2(Random.Range(-1f, -2f), -1f).normalized * speed;
            }
        }
    }
}
