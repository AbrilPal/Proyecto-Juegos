using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RelojNivel2 : MonoBehaviour
{
    public Personita script;
    public Text TxtReloj;
    private float countdown = 240;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        TxtReloj = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        TxtReloj.text = countdown.ToString("Faltan " + "0");
        if (countdown <= 0)
        {
            if (script.puntuacion >= 20)
            {
                SceneManager.LoadScene("Menu");
            }
            else if (script.puntuacion < 20)
            {
                SceneManager.LoadScene("GameOver");
            }

        }
    }
}
