using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public GameObject ekran;

    public void nowaScena(string nazwaSceny){
        Time.timeScale = 1f;
        SceneManager.LoadScene(nazwaSceny);
    }

    public void Pause(){
        ekran.SetActive(true);
        Time.timeScale = 0f;
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject == GameObject.FindGameObjectWithTag("Player"))
            Pause();
    }
}