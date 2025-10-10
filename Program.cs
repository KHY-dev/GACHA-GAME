using System;
using System.Linq;

namespace GACHA_GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 내가 가지고 있는 캐릭터를 볼 수 있는 기능
            // 2. 캐릭터 가챠 기능
            // ㄴ 희귀도에 따른 등장 확률 설정
            
            // TODO: 이미 보유 중인 캐릭터라면 어떤 식으로 처리할지
            // ㄴ 1. 기존 캐릭터 강화 (레벨 시스템)
            // ㄴ 2. 캐릭터 강화 재화로 변환 (재화 시스템)
            // 1번으로 결정
            // 3. 시간이 가능할 경우 타워디펜스 형태의 전투 구현 (레퍼런스: 명일방주 혹은 무기미도)
            // 4. static 등을 사용해 총 뽑기 횟수나 희귀도 별 뽑기 횟수 기록 기능 추가
            // 5. 4를 업적 등으로 활용

            //////// 테스트 코드
            //Console.WriteLine(Gacha.PickUp_1().Name);

            // 시간 상 구현한 것: 캐릭터 가챠 기능과 캐릭터 목록 확인

            // 1. 이름을 입력해 주세요
            Console.Write("플레이어 이름을 입력해 주세요: ");
            Player player = new Player
            {
                Name = Console.ReadLine()
            };
            Console.WriteLine($"{player.Name}님 환영합니다!");
            
            // 2. 캐릭터 뽑기
            while (true)
            {
                Console.WriteLine("1. 캐릭터 뽑기, 2. 캐릭터 확인, 3. 종료");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Character newCharacter = Gacha.PickUp_1();
                    Console.WriteLine($"축하합니다! {newCharacter.Name}({new string('★', (int)newCharacter.Rarity)}) 캐릭터를 획득하였습니다!");
                    // 이미 보유 중인 캐릭터인지 확인
                    var existingCharacter = player.Characters.FirstOrDefault(c => c.Name == newCharacter.Name);
                    if (existingCharacter != null)
                    {
                        Console.WriteLine($"{newCharacter.Name} 캐릭터는 이미 보유 중입니다. 기존 캐릭터가 강화되었습니다!");
                        // 기존 캐릭터 강화 로직 추가 예정
                    }
                    else
                    {
                        player.Characters.Add(newCharacter);
                        Console.WriteLine($"{newCharacter.Name} 캐릭터가 {player.Name}님의 캐릭터 목록에 추가되었습니다.");
                    }
                }
                else if (input == "2")
                {
                    player.ViewCharacters();
                }
                else if (input == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 1~3을 입력해 주세요.");
                }
            }
        }
    }
}
