using System.Collections.Generic;
using UnityEngine;
using static DeckManager;
//using static HandManager;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    public static Vector2[] direction = 
        { 
            Vector2.down,
            Vector2.up, 
            Vector2.left,
            Vector2.right
        };

    public static Quaternion[] rotation =
        {
            Quaternion.Euler(0, 0, 0),
            Quaternion.Euler(0, 0, -90),
            Quaternion.Euler(0, 0, 180),
            Quaternion.Euler(0, 0, 180),
            Quaternion.Euler(0, 0, 90)
        };

    public static int playerNumber = 5;

    public static int dealCardNumber = 10;

    public GameObject playArea;

    public RectTransform playAreaRect;

    public List<GameObject> playAreaList;

    void Awake()
    {
        if (GM == null)
        {
            GM = this;
        }

        playAreaRect = playArea.GetComponent<RectTransform>();
    }

    void Start()
    {

    }

}
