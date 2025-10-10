using System;

namespace GACHA_GAME
{
    internal class Gacha
    {
        // 랜덤 캐릭터 뽑기 - 1명
        public static Character PickUp_1()
        {
            // 1성 뽑을 확률: 49%
            // 2성 뽑을 확률: 30%
            // 3성 뽑을 확률: 15%
            // 4성 뽑을 확률: 5%
            // 5성 뽑을 확률: 1%

            decimal rand = new Random().Next(1, 101);
            // 희귀도 별 확률
            if (rand <= 1) // 1%
                return new Character { Name = "비올라", Rarity = Rarity.FiveStar };
            else if (rand <= 6) // 5%
                return new Character { Name = "제이", Rarity = Rarity.FourStar };
            else if (rand <= 21) // 15%
                return new Character { Name = "헤일러", Rarity = Rarity.ThreeStar };
            else if (rand <= 51) // 30%
                return new Character { Name = "효아", Rarity = Rarity.TwoStar };
            else // 49%
                // 나중엔 여러 1성 캐릭터 중 랜덤으로 뽑히도록 수정 예정
                return new Character { Name = "서현", Rarity = Rarity.OneStar };
        }

        // 랜덤 캐릭터 뽑기 - 10명 (구현 예정)
        //public Character PickUp_10() { }
    }
}
