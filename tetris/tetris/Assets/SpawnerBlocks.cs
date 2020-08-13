using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerBlocks : MonoBehaviour
{
    GameObject resumeBut, quitBut, menuBut;

    float scoreTime = 0;
    int score = 0;
    public Text scoreText;
    public GameObject[] Tetrominoes;
    void Start()
    {
        resumeBut = GameObject.Find("resume");
        quitBut = GameObject.Find("quit");
        menuBut = GameObject.Find("menu");
        quitBut.SetActive(false);
        resumeBut.SetActive(false);


        NewTetromino();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTime += Time.deltaTime;
        if (scoreTime > 1)
        {
            score += 1;
            scoreText.text = "SCORE : " + score.ToString();
            scoreTime = 0;
        }
    }
    public void NewTetromino()
    {
        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
    }
    public void button(int button)
    {
        if (button == 0)
        {
            Time.timeScale = 0;
            resumeBut.SetActive(true);
            quitBut.SetActive(true);
            menuBut.gameObject.GetComponent<Button>().interactable = false;

        }
        else if (button == 1)
        {
            Time.timeScale = 1;
            resumeBut.SetActive(false);
            quitBut.SetActive(false);
            menuBut.gameObject.GetComponent<Button>().interactable = true;
        }
        else if (button == 2)
        {
            Application.Quit();
        }
    }
}
