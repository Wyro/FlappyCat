using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public bool StartGame = false;

    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<Rigidbody2D>().simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 || StartGame)
        {
            Player.GetComponent<PlayerController>().enabled = true;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
