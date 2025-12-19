using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static GameManager;
using static DeckManager;
using static UIManager;
using static HandManager;

public class Card : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField]
    private Suits suit;
    [SerializeField]
    private int rank;
    [SerializeField]
    private Sprite face;
    [SerializeField]
    private Sprite back;
    [SerializeField]
    private int whoseCard;
    [SerializeField]
    private bool isHidden = false;
    [SerializeField]
    private int cardWidth = 50;
    [SerializeField]
    private int cardHeight = 72;

    private Image cardImage;
    private RectTransform cardRect;
    private Vector3 originPos;

    public void Init(Suits _suit, int _rank, Sprite _face)
    {
        suit = _suit;
        rank = _rank;
        face = _face;

        if (back == null)
        {
            back = Resources.Load<Sprite>($"Standard 52 Cards/Standard Cards/Card Back/card_back");
        }

        cardImage = GetComponent<Image>();

        cardRect = GetComponent<RectTransform>();

        transform.SetParent(UM.transform, false);

        Flip();
    }

    public void Flip()
    {
        if (isHidden)
        {
            cardImage.sprite = face;

            isHidden = false;
        }

        else
        {
            cardImage.sprite = back;

            isHidden = true;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.pointerCurrentRaycast.worldPosition;

        int newSiblingIndex = HM.handArea[0].transform.childCount;

        for (int i = 0; i < HM.handArea[0].transform.childCount; i++)
        {
            if (transform.position.x < HM.handArea[0].transform.GetChild(i).position.x)
            {
                newSiblingIndex = i;
                if (HM.dummyCard.transform.GetSiblingIndex() < newSiblingIndex)
                    newSiblingIndex--;
                break;
            }
        }

        HM.dummyCard.transform.SetSiblingIndex(newSiblingIndex);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        HM.dummyCard.SetActive(true);

        originPos = transform.position;

        HM.dummyCard.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());

        gameObject.transform.SetParent(UM.transform);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (transform.position.y > -2)
        {
            transform.SetParent(GM.playArea.transform);
            HM.handList[0].Remove(this.gameObject);
            HM.HandSize(0);
        }
        else
        {
            transform.position = originPos;
            transform.SetParent(HM.handArea[0].transform);
            transform.SetSiblingIndex(HM.dummyCard.transform.GetSiblingIndex());
        }

        HM.dummyCard.SetActive(false);
    }
}