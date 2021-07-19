using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard, yo");
        Debug.Log("Pick a number, don't tell me what it is ...");
        Debug.Log(string.Format("The highest number you can pick is: {0}", max));
        Debug.Log(string.Format("The lowest number you can pick is: {0}", min));
        Debug.Log(string.Format("Tell me if your number is higher or lower than: {0}", guess));
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        max++;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key: KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
            
        }
        else if (Input.GetKeyDown(key: KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(key: KeyCode.Return))
        {
            Debug.Log("Im a genius");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log(string.Format("Is it higher or lower than...{0}", guess));
    }
}
