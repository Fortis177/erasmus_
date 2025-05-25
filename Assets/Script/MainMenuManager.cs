using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Harita"); // Veya "GameScene" — nereye gitmek istiyorsan
    }
}
