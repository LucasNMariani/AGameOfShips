using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text lifeText;
    public Player player;
    public Text recolectableBoxes;
    public GameObject deathPanel;
    public GameObject winPanel;
    public GameObject creditsControls;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }
    
    void Start()
    {
        lifeText.text = "Lifes: " + player.PlayerLife;
        recolectableBoxes.text = " " + player.PlayerBoxes;
    }

    public void RefreshLifeOnScreen()
    {
        lifeText.text = "Lifes: " + player.PlayerLife;
    }
    public void RefreshBoxesOnScreen()
    {
        recolectableBoxes.text = " " + player.PlayerBoxes;
    }
    public void alpistePerdiste()
    {
        deathPanel.SetActive(true);
        Time.timeScale = 0.5f;
    }
    public void SetActiveWinPanel()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;
        
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void level1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void autorRightsAndControls()
    {
        creditsControls.SetActive(true);
        Time.timeScale = 0.5f;
    }
    public void menú()
    {
        creditsControls.SetActive(false);
        Time.timeScale = 0.5f;
    }

}
