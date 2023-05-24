using UnityEngine;
using UnityEngine.UI;

public class Tekst : MonoBehaviour
{
    public InputField usernameInput; //A public gameobject to assign the inputField
    public Text usernameDisplay; //A public string used to get the text input
    private const string PlayerPrefsKey = "Username"; // A private constant string variable which assigns the string 'username' as a key to PlayerPrefsKey

    private void Start()
    {
        LoadUsername(); //The method LoadUsername(); is called. To load the input from the user, save it and display it on the main screen
    }

    private void Update()
    {
        usernameDisplay.text = PlayerPrefs.GetString(PlayerPrefsKey); // Assigning the string value assigned with the key Username saved in Playerprefs,
    }                                                                  // to the text input gotten from the user.
    private void LoadUsername() // Method used to assign the value of the saved key username, to a string value gotten from the user. 
    {
        if (PlayerPrefs.HasKey(PlayerPrefsKey)) // checks if the key exists in the playerprefs system.
        {
            string username = PlayerPrefs.GetString(PlayerPrefsKey); //Retrieves the string value associated with the key from the PlayerPrefs system
                                                                     // this value is then stored in the username variable
            usernameInput.text = username;                           //Assign the value retrieved from the username variable
            usernameDisplay.text = username;                         //Assign the value retrieved from the username variable to the display text, showing the username to the user
        }
    }
    public void SaveUsername() //Method to save the username of the user
    {
        string username = usernameInput.text; //Sets the text value input from the user to the variable username. 
        usernameDisplay.text = username; //Assigns the display text to value in the username variable.
        PlayerPrefs.SetString(PlayerPrefsKey, username); //Stores the username value in the PlayerPrefs system. The method takes the two parameters the key, and the value of username.
                                                         //This associates the username to the specific key, which allows us to retrieve that specific value later
        PlayerPrefs.Save();                              //Saves the changes made to the PlayerPrefs system. This ensures that the changes are saved immediately, than on application quit
    }

}
