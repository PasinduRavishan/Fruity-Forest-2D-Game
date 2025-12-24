using System;
using UnityEngine;
using UnityEngine.UIElements;

public class UImanager : MonoBehaviour
{
    public UIDocument uiDocument;
    public GameManager gameManager;
    
    private VisualElement root;
    private TextElement scorecount;
    private TextElement lifecount;
    private VisualElement gameOverOverlay;
    private Button tryagain;

    private void OnEnable()
    {
        root = uiDocument.rootVisualElement;
        
        scorecount = root.Q<TextElement>("score-label");
        lifecount = root.Q<TextElement>("life-label");
        gameOverOverlay = root.Q<VisualElement>("gameoveroverlay"); 
        tryagain = root.Q<Button>("tryagain");
    }


    private void Update()
    {
        scorecount.text = $"Score : {gameManager.score}";
        lifecount.text = $"X {gameManager.life}";
        if (gameManager.gameOver == true)
        {
            gameOverOverlay.style.display = DisplayStyle.Flex;
            tryagain.RegisterCallback<ClickEvent>(evt => gameManager.RestartAgain());
        }

        
    }
}
