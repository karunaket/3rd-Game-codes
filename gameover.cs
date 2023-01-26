using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    [SerializeField] GameObject _something;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cactus")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("restart_screen");
        }
    }
}