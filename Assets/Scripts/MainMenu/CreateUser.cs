using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreateUser : MonoBehaviour
{
    [SerializeField] private Button _submitButton;
    [SerializeField] private Text username;

    void Start()
    {
        _submitButton.onClick.AddListener(CreateUsername);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void CreateUsername()
    {
        if(username.text.Length >= 3)
        {
            // Save User data

            LoadScene();
        }
    }
}
