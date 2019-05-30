using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RelojNivel1 : MonoBehaviour
{
    public Personita script;
    public Text TxtReloj;
    private float countdown = 120;

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
            if(script.puntuacion >= 15)
            {
                SceneManager.LoadScene("RelojNivel2");
            }
            else if (script.puntuacion < 15)
            {
                SceneManager.LoadScene("GameOver");
            }

        }
    }




}
