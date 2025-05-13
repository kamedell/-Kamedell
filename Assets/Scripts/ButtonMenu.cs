using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    void Start()
    {
        
    }
    public void Continue()
    {
      SceneManager.LoadScene(1);
      Debug.Log("Кнопка нажата");
    }
}
