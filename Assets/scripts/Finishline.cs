using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    bool end= false;
    [SerializeField] bool changescene;
    private void Update()
    {
        if (end == true)
        {

            Time.timeScale = 0f;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player 1")
        {
            player1.SetActive(true);
            end = true;
            if (changescene == true)
            {
                nextscene();
            }
        }
        if (collision.gameObject.tag == "Player 2")
        {
            player2.SetActive(true);
            end = true;
            if (changescene == true)
            {
                nextscene();
            }
            

        }

    }
    void nextscene()
    {
        SceneManager.LoadScene("level2");
    }
}
