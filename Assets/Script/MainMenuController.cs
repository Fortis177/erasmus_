using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MainMenuController : MonoBehaviour
{
    private Button playButton;
    private CanvasGroup uiGroup;

    [Header("Fade süresi (sn)")]
    public float fadeDuration = 1.5f;   // 1.5 saniye yaparak daha belirgin fade

    void Awake()
    {
        // CanvasGroup’ı al
        uiGroup = GetComponent<CanvasGroup>();
        if (uiGroup == null)
        {
            Debug.LogError("[MainMenuController] CanvasGroup yok!", this);
            return;
        }

        // Child olarak “PlayButton” bul
        var btnT = transform.Find("PlayButton");
        if (btnT == null)
        {
            Debug.LogError("[MainMenuController] PlayButton child bulunamadı!", this);
            return;
        }

        playButton = btnT.GetComponent<Button>();
        if (playButton == null)
        {
            Debug.LogError("[MainMenuController] PlayButton üzerinde Button bileşeni yok!", this);
            return;
        }

        // Dinleyici ekle
        playButton.onClick.AddListener(OnPlayClicked);
    }

    private void OnPlayClicked()
    {
        StartCoroutine(FadeThenLoad("Harita"));
    }

    private IEnumerator FadeThenLoad(string sceneName)
    {
        // tıklamayı kapat
        uiGroup.interactable = false;
        uiGroup.blocksRaycasts = false;

        // Asenkron yüklemeyi başlat, ama hemen sahneyi aktifleştirme
        var asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        asyncLoad.allowSceneActivation = false;

        // Fade‑out
        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            uiGroup.alpha = Mathf.Lerp(1f, 0f, elapsed / fadeDuration);
            yield return null;
        }
        uiGroup.alpha = 0f;

        // Fade bitti, şimdi sahneyi aktifleştir
        asyncLoad.allowSceneActivation = true;
    }
}
