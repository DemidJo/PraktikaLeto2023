using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{
        Image timerBar;
        public GameObject pauseGameMenu;
        public float maTime = 20f;
        float timeLeft;
        public bool PauseGame;

    void Start (){

        timerBar = GetComponent <Image>();
        timeLeft = maTime;

    }

    void Update ()
    {
        if (timeLeft <= 0)
            {
            Pause ();
            }
          if (timeLeft>0)
            {
                timeLeft -= Time.deltaTime;
                timerBar.fillAmount = timeLeft / maTime;

            } 
            else 
            {
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
            }


            if (timeLeft <= 0)
            {
           LosdMenu();
            }
    
    }

     public void Pause ()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true; 

    }
    public void LosdMenu()
    {
        if (PauseGame)
        {
      Time.timeScale = 1f;
        
        SceneManager.LoadScene("Menu");
        }
    }
}