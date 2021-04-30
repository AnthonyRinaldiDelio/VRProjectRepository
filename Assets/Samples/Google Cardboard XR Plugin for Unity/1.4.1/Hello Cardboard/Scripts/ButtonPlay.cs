using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class ButtonPlay : MonoBehaviour
{
    private Button button;
    private TMP_Text textmashpro;
    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        //textmashpro = GetComponent<TMP_Text>(); for debuggiing~
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEneter()
    {
       
    }

    public void OnPonterExit()
    {
        
    }

    public void OnPointerClick()
    {
        button.onClick.Invoke();

    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
