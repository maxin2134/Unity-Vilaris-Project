using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceny : MonoBehaviour
{
    public static bool czyPauza = false;

    public GameObject menuPauza;

    public void nowaScena(string nazwaSceny){
        Time.timeScale = 1f;
        czyPauza = false;
        SceneManager.LoadScene(nazwaSceny);
    }

    public void Wyjscie(){
        Application.Quit();
    }

    void Update(){
        if(czyPauza == false)
            if (Input.GetKeyDown(KeyCode.Escape))
                Pause();
    }

    public void Resume(){
        menuPauza.SetActive(false);
        Time.timeScale = 1f;
        czyPauza = false;
    }

    public void Pause(){
        menuPauza.SetActive(true);
        Time.timeScale = 0f;
        czyPauza = true;
    }
   
}