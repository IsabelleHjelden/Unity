using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private Button game1Button;
    [SerializeField] private Button NotQuitePlatformerButton;
    [SerializeField] private Button creditsOpenButton;
    [SerializeField] private Button creditsClosedButton;
    [SerializeField] private GameObject creditsUI;





    // Start is called before the first frame update
    void Awake()
    {
        creditsOpenButton.onClick.AddListener(() => { creditsUI.SetActive(true); });
        creditsClosedButton.onClick.AddListener(() => { creditsUI.SetActive(false); });

        game1Button.onClick.AddListener(() => LoadingScreen.LoadScene("GameScene1"));
        NotQuitePlatformerButton.onClick.AddListener(() => LoadingScreen.LoadScene("NotQuitePlatformer"));

    }

}
