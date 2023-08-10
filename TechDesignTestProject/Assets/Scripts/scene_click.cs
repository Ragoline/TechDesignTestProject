using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_click : MonoBehaviour
{
    public void SwitchScene(int currentScene)
    {
        switch (currentScene)
        {
            case 1:
                SceneManager.LoadScene("second_scene");
                break;

            case 2:
                SceneManager.LoadScene("first_scene");
                break;
        }
    }
}
