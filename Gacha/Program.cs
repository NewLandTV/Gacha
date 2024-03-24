using System;
using System.Collections.Generic;
using System.Threading;

namespace Gacha
{
    class Program
    {
        private const int WIDTH = 184;
        private const int HEIGHT = 50;

        private static List<string> GatchList = new List<string>()
        {
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
            "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "/", "?", "\\", "|", "\'", "\"", "<", ">", ",", ".", "[", "{", "]", "}", ";", ":", " ",
            "가", "갸", "거", "겨", "고", "교", "구", "규", "그", "기",
            "나", "냐", "너", "녀", "노", "뇨", "누", "뉴", "느", "니",
            "다", "댜", "더", "뎌", "도", "됴", "두", "듀", "드", "디",
            "라", "랴", "러", "려", "로", "료", "루", "류", "르", "리",
            "마", "먀", "머", "며", "모", "묘", "무", "뮤", "므", "미",
            "바", "뱌", "버", "벼", "보", "뵤", "부", "뷰", "브", "비",
            "사", "샤", "서", "셔", "소", "쇼", "수", "슈", "스", "시",
            "아", "야", "어", "여", "오", "요", "우", "유", "으", "이",
            "자", "쟈", "저", "져", "조", "죠", "주", "쥬", "즈", "지",
            "차", "챠", "처", "쳐", "초", "쵸", "추", "츄", "츠", "치",
            "카", "캬", "커", "켜", "코", "쿄", "쿠", "큐", "크", "키",
            "타", "탸", "터", "텨", "토", "툐", "투", "튜", "트", "티",
            "파", "퍄", "퍼", "펴", "포", "표", "푸", "퓨", "프", "피",
            "하", "햐", "허", "혀", "호", "효", "후", "휴", "흐", "히",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
        };

        static void Main(string[] args)
        {
            Console.Title = "Random Typing";
            Console.CursorVisible = false;

            Console.SetWindowSize(WIDTH, HEIGHT);

            for (int i = 0; ; i++)
            {
                Gatch(i);

                Thread.Sleep(20);
            }
        }

        private static void Gatch(int i)
        {
            Console.ForegroundColor = (ConsoleColor)new Random().Next(0, 16);
            Console.BackgroundColor = (ConsoleColor)new Random().Next(0, 16);

            Console.SetCursorPosition(new Random().Next(4, WIDTH), new Random().Next(0, HEIGHT));
            Console.Write(GatchList[new Random().Next(0, GatchList.Count)]);
            Console.Beep(new Random().Next(100, 2022), new Random().Next(40, 120));

            if (i % new Random().Next(10, 100) == 0)
            {
                Console.Clear();
            }

            for (int j = 0; j < HEIGHT; j++)
            {
                Console.ForegroundColor = (ConsoleColor)new Random().Next(0, 16);
                Console.BackgroundColor = (ConsoleColor)new Random().Next(0, 16);

                Console.SetCursorPosition(0, j);

                if (j != HEIGHT - 1)
                {
                    Console.WriteLine(j + 1);
                }
                else
                {
                    Console.Write(j + 1);
                }
            }
        }
    }
}
