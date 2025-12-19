using UnityEngine;
using static GameManager;
using static DeckManager;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class HandManager : MonoBehaviour
{
    public static HandManager HM;

    [SerializeField]
    public List<GameObject>[] handList;

    public GameObject[] handArea = new GameObject[5];

    public GameObject dummyCard;
    public RectTransform dummyCardRect;
    public LayoutElement dummyLayoutElement;

    private void Awake()
    {
        if (HM == null)
        {
            HM = this;
        }

        handList = new List<GameObject>[playerNumber];

        for (int i = 0; i < playerNumber; i++)
        {
            handList[i] = new List<GameObject>();
        }

        dummyCardRect = dummyCard.GetComponent<RectTransform>();
        dummyLayoutElement = dummyCard.GetComponent<LayoutElement>();

    }

    public IEnumerator AddCardToHand(GameObject card, int who)
    {
        while(Vector2.Distance(card.transform.position, handArea[who].transform.position) > 0.1f)
        {
            card.transform.position
                = Vector2.Lerp(card.transform.position, handArea[who].transform.position, Time.deltaTime * 10);

            card.transform.rotation
                = Quaternion.Lerp(card.transform.rotation, rotation[who], Time.deltaTime * 10);

            yield return null;
        }

        handList[who].Add(card);

        card.transform.SetParent(handArea[who].transform);

        card.transform.rotation = rotation[who];

        if (who == 0)
        {
            card.GetComponent<Card>().Flip();
        }
    }

    public void HandSize(int who)
    {
        int handCount = handList[who].Count;

        switch (who)
        {
            case 0:
                HorizontalLayoutGroup layoutP = handArea[who].GetComponent<HorizontalLayoutGroup>();
                layoutP.spacing = -720 + handCount * 52;
                layoutP.enabled = false;
                layoutP.enabled = true;
                break;

            case 1:
            case 4:
                VerticalLayoutGroup layoutV = handArea[who].GetComponent<VerticalLayoutGroup>();
                layoutV.spacing = -270 + handCount * 18;
                layoutV.enabled = false;
                layoutV.enabled = true;
                break;

            case 2:
            case 3:
                HorizontalLayoutGroup layoutH = handArea[who].GetComponent<HorizontalLayoutGroup>();
                layoutH.spacing = -270 + handCount * 18;
                layoutH.enabled = false;
                layoutH.enabled = true;
                break;
        }
    }
}
