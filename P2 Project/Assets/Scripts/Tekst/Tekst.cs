using UnityEngine;
using UnityEngine.UI;

public class Tekst : MonoBehaviour
{
    public InputField usernameInput;
    public Text usernameDisplay;
    private const string PlayerPrefsKey = "Username";

    private void Start()
    {
        LoadUsername();
    }

    private void LoadUsername()
    {
        if (PlayerPrefs.HasKey(PlayerPrefsKey))
        {
            string username = PlayerPrefs.GetString(PlayerPrefsKey);
            usernameInput.text = username;
            usernameDisplay.text = username;
        }
    }
    public void SaveUsername()
    {
        string username = usernameInput.text;
        usernameDisplay.text = username;
        PlayerPrefs.SetString(PlayerPrefsKey, username);
        PlayerPrefs.Save();
    }
}
