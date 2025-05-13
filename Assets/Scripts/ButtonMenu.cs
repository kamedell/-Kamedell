using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour
{ 
  [Header("КнопкаПродолжить")]
  public Button ButContinue;
  [Header("Панели")] 
  public GameObject PanelContinue;
  public GameObject PanelNewGame;
  public GameObject PanelSettings;
  public GameObject PanelDevelopment;
  public GameObject PanelExit;
    void Start()
    {
        if(PlayerPrefs.HasKey("Chapter1")) 
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
}
