using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    public GameObject gameOverText;
    public GameObject startText;
    public Text score1Text;
    public Text score2Text;
    public Text health1Text;
    public Text health2Text;
    public GameObject player1Wins;
    public GameObject player2Wins;
    public GameObject Draw;
    public Text b1Text,b2Text,b3Text,b4Text,b5Text,b6Text;
    public bool gameOver = false;
    public bool start = true;
    public int score1, score2 = 0;
    public int health1, health2 = 105;
    public int b1 = 5;
    public int b2 = 5;
    public int b4 = 5;
    public int b3 = 5;
    public int b5 = 5;
    public int b6 = 5;
    // Use this for initialization
    void Awake () {
		if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(gameOver==true && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(start==true && Input.GetKeyDown(KeyCode.Space))
        {
            startText.SetActive(false);
            start = false;
        }
	}

    public void player1Scored()
    {
        if(gameOver)
        {
            return;
        }
        score1++;
        score1Text.text = "Player 1 Score: " + score1.ToString();
        if (score1 >= 20)
        {
            gameOverText.SetActive(true);
            player1Wins.SetActive(true);
            gameOver = true;
        }
    }

    public void player1Scored5()
    {
        if (gameOver)
        {
            return;
        }
        score1=score1+3;
        score1Text.text = "Player 1 Score: " + score1.ToString();
        if (score1 >= 20)
        {
            gameOverText.SetActive(true);
            player1Wins.SetActive(true);
            gameOver = true;
        }
    }

    public void player2Scored5()
    {
        if (gameOver)
        {
            return;
        }
        score2=score2+3;
        score2Text.text = "Player 2 Score: " + score2.ToString();
        if(score2>=20)
        {
            gameOverText.SetActive(true);
            player2Wins.SetActive(true);
            gameOver =true;
        }
    }

    public void player2Scored()
    {
        if (gameOver)
        {
            return;
        }
        score2++;
        score2Text.text = "Player 2 Score: " + score2.ToString();
        if (score2 >= 20)
        {
            gameOverText.SetActive(true);
            player2Wins.SetActive(true);
            gameOver = true;
        }
    }

    public void player1TakesDamage()
    {
        if (gameOver)
        {
            return;
        }
        health1 = health1 - 5;
        health1Text.text = "Shield: " + health1;
    }

    public void player2TakesDamage()
    {
        if (gameOver)
        {
            return;
        }
        health2 = health2 - 5;
        health2Text.text = "Shield: " + health2;
    }

    public void b1TakesDamage()
    {
        b1--;
        b1Text.text = "" + b1;
    }

    public void b2TakesDamage()
    {
        b2--;
        b2Text.text = "" + b2;
    }

    public void b3TakesDamage()
    {
        b3--;
        b3Text.text = "" + b3;
    }

    public void b4TakesDamage()
    {
        b4--;
        b4Text.text = "" + b4;
    }

    public void b5TakesDamage()
    {
        b5--;
        b5Text.text = "" + b5;
    }

    public void b6TakesDamage()
    {
        b6--;
        b6Text.text = "" + b6;
    }


    public void shipDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
        if (health1==0 && health2 == 0)
        {
            Draw.SetActive(true);
        }
        else if(health1==0)
        {
            player2Wins.SetActive(true);
        }
        else if (health2 == 0)
        {
            player1Wins.SetActive(true);
        }

    }
}
