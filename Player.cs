using System;
using System.Collections.Generic;

namespace GACHA_GAME
{
    class Player
    {
        private string _name;
        private List<Character> _characters = new List<Character>();

        public string Name { get => _name; set => _name = value; }
        public List<Character> Characters { get => _characters; set => _characters = value; }

        public void ViewCharacters()
        {
            Console.WriteLine("내가 보유한 캐릭터 목록");

            foreach (var character in Characters)
            {
                Console.WriteLine($"이름: {character.Name}({new string('★', (int)character.Rarity)})");
            }
        }
    }
}
