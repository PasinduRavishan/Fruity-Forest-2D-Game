using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    public UIDocument uiDocument;
    
    private Button playButton;
    private VisualElement root;

    private void OnEnable()
    {
        root = uiDocument.rootVisualElement;
        playButton = root.Q<Button>("playbutton");
    }

    private void Update()
    {
        playButton.RegisterCallback<ClickEvent>(evt => OnPlayButtonClick());
    }

    private void OnPlayButtonClick()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
