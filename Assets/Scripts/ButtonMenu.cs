using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour
{ 
   [Header("Сохранение глав")]
  public string Chapter1Key = "Chapter1"; 
  public string Chapter2Key = "Chapter2";
  public string Chapter3Key = "Chapter3";
  public string Chapter4Key = "Chapter4";

  [Header("Кнопка Продолжить")]
  public Button ButContinue;
  [Header("Панели")] 
  public GameObject PanelContinue;
  public GameObject PanelNewGame;
  public GameObject PanelSettings;
  public GameObject PanelDevelopment;
  public GameObject PanelExit;
     void Start()
    {
    if (PlayerPrefs.HasKey(Chapter1Key) || PlayerPrefs.HasKey(Chapter2Key) || PlayerPrefs.HasKey(Chapter3Key) || PlayerPrefs.HasKey(Chapter4Key))
       {
         ButContinue.gameObject.SetActive(true); 
       }
       else
       {
         ButContinue.gameObject.SetActive(false); 
       }
    }
    public void Continue()
    {
      SceneManager.LoadScene(1);
      Debug.Log("Кнопка нажата");
    }
    public void NewGame()
    { 
      if(PlayerPrefs.HasKey("Chapter1")) 
      {
      PlayerPrefs.SetInt("Chapter1", 1);
      SceneManager.LoadScene(1);
      Debug.Log("Кнопка нажата");
      }
    }   
}