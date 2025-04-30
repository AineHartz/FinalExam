using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene("gameplay");
    }
}
