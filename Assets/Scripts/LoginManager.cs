using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TextMeshProUGUI feedbackText;

    public string expectedUsername = "qwq";
    public string expectedPassword = "6688";
    public string sceneToLoad = "SampleScene";   

    public void OnLoginButtonClicked()
    {
        string enteredUsername = usernameInput.text;
        string enteredPassword = passwordInput.text;

        if (enteredUsername == expectedUsername && enteredPassword == expectedPassword)
        {
            feedbackText.text = "Login successful!";
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            feedbackText.text = "Invalid username or password.";
        }
    }
}

