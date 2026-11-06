using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerTask7 : MonoBehaviour
{
    private int lives = 3;

    private void OnGUI()
    {
        Texture livesTexture = GetComponent<SpriteRenderer>().sprite.texture;
        int repetitions = 0;

        do
        {
            Rect drawLocation = new Rect(x:200 - 69 * repetitions, y:50, width:60, height:60);
            GUI.DrawTexture(drawLocation, livesTexture);
            repetitions = repetitions + 1;
        } while (repetitions < 3);
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
