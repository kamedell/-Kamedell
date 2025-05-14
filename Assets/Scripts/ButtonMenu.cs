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
    public void ButtonContinue()
    {
      int lastCompletedChapter = 0; //переменная, которая указывает сколько глав было пройдено
      Debug.Log("Кнопка нажата");
      if (PlayerPrefs.GetInt(Chapter4Key, 0) == 1)  
      {
        lastCompletedChapter = 5;
      } 
      else if (PlayerPrefs.GetInt(Chapter3Key, 0) == 1)
      {  
        lastCompletedChapter = 4;
      } 
      else if (PlayerPrefs.GetInt(Chapter2Key, 0) == 1)
        { 
          lastCompletedChapter = 3; 
        } 
      else if (PlayerPrefs.GetInt(Chapter1Key, 0) == 1)
        {
          lastCompletedChapter = 2;
        }
      
      if (lastCompletedChapter > 0) 
      {
        SceneManager.LoadScene(lastCompletedChapter);
      } 
    }
    public void ButtonNewGame()
    {      
      PlayerPrefs.DeleteKey("Сhapter2");
      PlayerPrefs.DeleteKey("Сhapter3");
      PlayerPrefs.DeleteKey("Сhapter4");
      PlayerPrefs.SetInt("Chapter1", 1);
      SceneManager.LoadScene(1);
      PlayerPrefs.Save();
      Debug.Log("Кнопка нажата");
      
    }
    public void ButtonQuit()
    {
      Application.Quit();
    } 
       public void MarkChapterAsCompleted(int chapterNumber) //данный метод служит для сохранения пройденной главы
    {
        string chapterKey = "Chapter" + chapterNumber; 
        PlayerPrefs.SetInt(chapterKey, 1);
        PlayerPrefs.Save();
        Debug.Log("Глава " + chapterNumber + " пройдена.");
    }
}