using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static GameManager;
using static HandManager;
//using static HandManager;

public class DeckManager : MonoBehaviour
{
    public static DeckManager DM;
    public enum Suits
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    private List<GameObject> deck;

    [SerializeField]
    private GameObject cardPrefab;

    public WaitForSeconds Delay(float time)
    {
        WaitForSeconds d = new(time);
        return d;
    } 

    void Awake()
    {
        if (DM == null)
        {
            DM = this;
        }

        if (cardPrefab == null)
        {
            cardPrefab = Resources.Load<GameObject>("card");
        }
        
        deck = new List<GameObject>();

        
    }
    void Start()
    {
        CreateNewDeck();

        StartCoroutine(StartNewRound());

        StartCoroutine(Deal());
    }

    private IEnumerator Deal() //GameObject card, GameObject hand, int who
    {
        for (int who = 0; who < playerNumber; who++)
        {
            for (int i = 0; i < dealCardNumber; i++)
            {
                int randomIndex = Random.Range(0, deck.Count);
                GameObject card = deck[randomIndex];
                deck.RemoveAt(randomIndex);
                StartCoroutine(HM.AddCardToHand(card, who));
                yield return Delay(0.1f);
            }
        }
    }


    public void CreateNewDeck()
    {
        for (int i = 0; i < 4; i++)
        {
            Suits suit = (Suits)i;

            for (int rank = 1; rank <= 13; rank++)
            {
                GameObject newCard = Instantiate(cardPrefab);

                Sprite face = Resources.Load<Sprite>($"Standard 52 Cards/Standard Cards/{suit}s/{rank}_{suit}");

                newCard.GetComponent<Card>().Init(suit, rank, face);

                deck.Add(newCard);
            }
        }
    }

    private IEnumerator StartNewRound()
    {
        yield return Delay(1);
    }
}

//for (int j = 0; j < playerNumber; j++)
//{
//    for (int i = 0; i < dealCardNumber; i++)
//    {
//        handManager.AddCard(deckManager.DrawRandomCard(), handManager.handList[j]);
//    }
//}
