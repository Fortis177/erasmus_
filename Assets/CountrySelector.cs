using UnityEngine;
using UnityEngine.SceneManagement;

public class CountrySelector : MonoBehaviour
{
    [Tooltip("Bu objenin ülke adý")]
    public string countryName;

    void OnMouseDown()
    {
        Debug.Log(countryName + " seçildi.");
        if (countryName == "Türkiye")
            SceneManager.LoadScene("GameScene");
        else
            Debug.Log("Henüz bu ülke için içerik yok.");
    }
}
