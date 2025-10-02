using System;

namespace GACHA_GAME
{
    public enum Rarity
    {
        OneStar = 1,
        TwoStar,
        ThreeStar,
        FourStar,
        FiveStar
    }

    public class Character
    {
        private string _name;
        private Rarity _rarity;

        public string Name { get => _name; set => _name = value; }
        public Rarity Rarity { get => _rarity; set => _rarity = value; }

        // 기타 속성은 전투 도입시 추가 예정
    }
}
