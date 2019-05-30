using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mario()
    {

        SceneManager.LoadScene("primero");
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void siguiente_mario()
    {
        SceneManager.LoadScene("segundo");
    }
    public void Mario2()
    {
        SceneManager.LoadScene("segundo");
    }
    public void Tiro()
    {
        SceneManager.LoadScene("RelojNivel1");
    }
}
