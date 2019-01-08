using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public bool StartGame = false;
    public Canvas PlayerUI;
    public Text InformationForPlayer;

    // Start is called before the first frame update
    void Start()
    {
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

    public void ShowUI(string Information)
    {
        PlayerUI.gameObject.SetActive(true);
        InformationForPlayer.text = Information;
    }
}
