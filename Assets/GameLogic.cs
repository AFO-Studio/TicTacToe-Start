using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{

    public Text gameText;
    public Text PlayerPointsTxt1;
    public Text PlayerPointsTxt2;

    //Buttons
    public Image[] slots;

    //Tracking the player turns
    //        1 || 2
    public int player = 1;

    int player1Wins = 0;
    int player2Wins = 0;



    //Images for Players

    public Sprite X,  Blank, O;

    public Player playerScript;

    bool gameOn = true;

    public GameObject RetryBtn;

    void Start()
    {
        playerScript = gameObject.GetComponent<Player>();
        
        gameText.text = "Let's Play!";

        ClearBoard();

        RetryBtn.SetActive(false);

        RetryBtn.GetComponentInChildren<Text>().text = "Play Again!";
    }





    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (gameOn == true)
        {
            PlayerPointsTxt1.text = "Player 1: " + player1Wins + " ";
            PlayerPointsTxt2.text = "Player 2: " + player2Wins + " ";

            player = playerScript.player;

            if (slots[0].sprite == X && slots[1].sprite == X && slots[2].sprite == X
                ||
                slots[0].sprite == X && slots[4].sprite == X && slots[8].sprite == X
                ||
                slots[2].sprite == X && slots[4].sprite == X && slots[6].sprite == X
                ||
                slots[3].sprite == X && slots[4].sprite == X && slots[5].sprite == X
                ||
                slots[2].sprite == X && slots[5].sprite == X && slots[8].sprite == X
                ||
                slots[0].sprite == X && slots[3].sprite == X && slots[6].sprite == X
                ||
                slots[6].sprite == X && slots[7].sprite == X && slots[8].sprite == X
                ||
                slots[1].sprite == X && slots[4].sprite == X && slots[7].sprite == X)
            {
                gameText.text = "Player 1 wins!";
                player1Wins += 1;
                RetryBtn.SetActive(true);
                gameOn = false;
            }

            if (slots[0].sprite == O && slots[1].sprite == O && slots[2].sprite == O
               ||
               slots[0].sprite == O && slots[4].sprite == O && slots[8].sprite == O
               ||
               slots[2].sprite == O && slots[4].sprite == O && slots[6].sprite == O
               ||
               slots[3].sprite == O && slots[4].sprite == O && slots[5].sprite == O
               ||
               slots[2].sprite == O && slots[5].sprite == O && slots[8].sprite == O
               ||
               slots[0].sprite == O && slots[3].sprite == O && slots[6].sprite == O
               ||
               slots[6].sprite == O && slots[7].sprite == O && slots[8].sprite == O
               ||
               slots[1].sprite == O && slots[4].sprite == O && slots[7].sprite == O)
            {
                gameText.text = "Player 2 wins!";
                player2Wins += 1;
                RetryBtn.SetActive(true);
                gameOn = false;
            }

            if (slots[0].sprite != Blank && slots[1].sprite != Blank && slots[2].sprite != Blank
                &&
                slots[3].sprite != Blank && slots[4].sprite != Blank && slots[5].sprite != Blank
                &&
                slots[6].sprite != Blank && slots[7].sprite != Blank && slots[8].sprite != Blank)
            {

                gameText.text = "Draw";
                RetryBtn.SetActive(true);
                gameOn = false;
            }
        }


    }

    public void ClearBoard()
    {
        for (int i = 0; i < (slots.Length); i++)
        {
            slots[i].sprite = Blank;
        }
        gameOn = true;
        RetryBtn.SetActive(false);
        gameText.text = "Playing...";
    }


    //Button handling

    public void UpperLeft()
    {
        if (gameOn == true)
        {

            if (slots[0].sprite == Blank)
            {
                if (player == 1)
                {
                    slots[0].sprite = X;
                    playerScript.player = 2;
                    gameText.text = "Player 2's turn.";
                    Debug.Log(player);
                }
                if (player == 2)
                {
                    slots[0].sprite = O;
                    playerScript.player = 1;
                    gameText.text = "Player 1's turn.";
                    Debug.Log(player);
                }
            }
            else
            {
                gameText.text = "Occupied Space";
            }
        }
    
    }



    public void UpperMiddle()
    {
        if (gameOn == true)
        {

            if (slots[1].sprite == Blank)
            {
                if (player == 1)
                {
                    slots[1].sprite = X;
                    playerScript.player = 2;
                    gameText.text = "Player 2's turn.";
                }
                if (player == 2)
                {
                    slots[1].sprite = O;
                    playerScript.player = 1;
                    gameText.text = "Player 1's turn.";
                }
            }
            else
            {
                gameText.text = "Occupied Space";
            }
        }
    }




    public void UpperRight()
    {
        if (gameOn == true)
        {

            if (slots[2].sprite == Blank)
            {
                if (player == 1)
                {
                    slots[2].sprite = X;
                    playerScript.player = 2;
                    gameText.text = "Player 2's turn.";
                }
                if (player == 2)
                {
                    slots[2].sprite = O;
                    playerScript.player = 1;
                    gameText.text = "Player 1's turn.";
                }
            }
            else
            {
                gameText.text = "Occupied Space";
            }
        }
    }



    public void MiddleLeft()
    {
        if (gameOn == true)
        {
            if (slots[3].sprite == Blank)
            {
                if (player == 1)
                {
                    slots[3].sprite = X;
                    playerScript.player = 2;
                    gameText.text = "Player 2's turn.";
                }
                if (player == 2)
                {
                    slots[3].sprite = O;
                    playerScript.player = 1;
                    gameText.text = "Player 1's turn.";
                }
            }
            else
            {
                gameText.text = "Occupied Space";
            }
        }
    }




    public void MiddleMiddle()
    {
        if (gameOn == true)
        {
            if (slots[4].sprite == Blank)
            {
                if (player == 1)
                {
                    slots[4].sprite = X;
                    playerScript.player = 2;
                    gameText.text = "Player 2's turn.";
                }
                if (player == 2)
                {
                    slots[4].sprite = O;
                    playerScript.player = 1;
                    gameText.text = "Player 1's turn.";
                }
            }
            else
            {
                gameText.text = "Occupied Space";
            }
        }
    }



    public void MiddleRight()
    {
        if (gameOn == true)
        {
            if (slots[5].sprite == Blank)
            {
                if (player == 1)
                {
                    slots[5].sprite = X;
                    playerScript.player = 2;
                    gameText.text = "Player 2's turn.";
                }
                if (player == 2)
                {
                    slots[5].sprite = O;
                    playerScript.player = 1;
                    gameText.text = "Player 1's turn.";
                }
            }
            else
            {
                gameText.text = "Occupied Space";
            }
        }
    }



    public void BottomLeft()
    {
        if (gameOn == true)
        {
            if (slots[6].sprite == Blank)
            {
                if (player == 1)
                {
                    slots[6].sprite = X;
                    playerScript.player = 2;
                    gameText.text = "Player 2's turn.";
                }
                if (player == 2)
                {
                    slots[6].sprite = O;
                    playerScript.player = 1;
                    gameText.text = "Player 1's turn.";
                }
            }
            else
            {
                gameText.text = "Occupied Space";
            }
        }
    }


    public void BottomMiddle()
    {
        if (gameOn == true)
        {
            if (slots[7].sprite == Blank)
            {
                if (player == 1)
                {
                    slots[7].sprite = X;
                    playerScript.player = 2;
                    gameText.text = "Player 2's turn.";
                }
                if (player == 2)
                {
                    slots[7].sprite = O;
                    playerScript.player = 1;
                    gameText.text = "Player 1's turn.";
                }
            }
            else
            {
                gameText.text = "Occupied Space";
            }
        }
    }


    public void BottomRight()
    {
        if (gameOn == true)
        {
            if (slots[8].sprite == Blank)
            {
                if (player == 1)
                {
                    slots[8].sprite = X;
                    playerScript.player = 2;
                    gameText.text = "Player 2's turn.";
                }
                if (player == 2)
                {
                    slots[8].sprite = O;
                    playerScript.player = 1;
                    gameText.text = "Player 1's turn.";
                }
            }
            else
            {
                gameText.text = "Occupied Space";
            }
        }
    }
}
