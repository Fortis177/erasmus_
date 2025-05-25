using UnityEngine;
using UnityEngine.SceneManagement;

public class CountrySelector : MonoBehaviour
{
    [Tooltip("Bu objenin �lke ad�")]
    public string countryName;

    void OnMouseDown()
    {
        Debug.Log(countryName + " se�ildi.");
        if (countryName == "T�rkiye")
            SceneManager.LoadScene("GameScene");
        else
            Debug.Log("Hen�z bu �lke i�in i�erik yok.");
    }
}
