using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GACHA_GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 내가 가지고 있는 캐릭터를 볼 수 있는 기능
            // 2. 캐릭터 가챠 기능
            // 희귀도에 따른 등장 확률 설정
            // 이미 보유 중인 캐릭터라면 어떤 식으로 처리할지
            // ㄴ 1. 기존 캐릭터 강화 (레벨 시스템)
            // ㄴ 2. 캐릭터 강화 재화로 변환 (재화 시스템)
            // 3. 시간이 가능할 경우 타워디펜스 형태의 전투 구현 (레퍼런스: 명일방주 혹은 무기미도)

            //////// 테스트 코드
            Console.WriteLine(Gacha.PickUp_1().Name);
        }
    }
}
