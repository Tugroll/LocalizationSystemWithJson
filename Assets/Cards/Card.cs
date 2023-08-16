using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Card
{
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject
    {
        public string title;
        public Sprite art;
        public string CardDetail;
        public string cardFlavor;
        public string artist;
    }
}