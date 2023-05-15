using UnityEngine;
using UnityEngine.UI;

public class UsernameManager : MonoBehaviour
{
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
            UpdateUsername(username);
        }
    }

    public void UpdateUsername(string username)
    {
        usernameDisplay.text = username;
    }
}
