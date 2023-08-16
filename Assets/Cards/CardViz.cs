using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Card
{
    public class CardViz : MonoBehaviour
    {
        public TextMeshProUGUI title;
        public TextMeshProUGUI detail;
        public TextMeshProUGUI flavor;
        public TextMeshProUGUI artist;

        public Image art;

        public Card card;

        private void Start()
        {
            LoadCard(card);
        }
        public void LoadCard(Card c)
        {
            card = c;
            title.text = c.title;
            detail.text = c.CardDetail;
            flavor.text = c.cardFlavor;
            artist.text = c.artist;
            art.sprite = c.art;
        }
    }
}