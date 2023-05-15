using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public InputField usernameInput;
    public GameObject canvas;
    private const string PlayerPrefsKey = "Username";

    public void SaveUsername()
    {
        string username = usernameInput.text;
        PlayerPrefs.SetString(PlayerPrefsKey, username);
        canvas.GetComponent<UsernameManager>().UpdateUsername(username);
    }
}
