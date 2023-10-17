using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public bool isJumping;
    public GameObject GameOver;

    Animator anim;
    string Jump_p = "Jump";

    public string nextSceneName = "Goal";
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        PlayerJump();
    }

    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
            anim.SetTrigger(Jump_p);
        }        
    }
    void PlayerLose()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResetTrigger()
    {
        anim.ResetTrigger(Jump_p);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            PlayerLose();
        }
    }

    public void ChangeMyScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            GoalManager.singleton.CollectCoin();
            Destroy(collision.gameObject);
        }

        else if (collision.CompareTag("Goal"))
        {
            if (GoalManager.singleton.canEnter)
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
