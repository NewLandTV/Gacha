#include <stdio.h>
#include <conio.h>
#include <time.h>
#include <stdlib.h>
#include <Windows.h>

#define CONSOLE_WIDTH 88
#define CONSOLE_HEIGHT 44

void Init();
void Update();
void Gotoxy(int x, int y);

int main(void)
{
	Init();
	
	while (1)
	{
		Update();
		Sleep(10);
	}
	
	return 0;
}

void Init()
{
	srand((unsigned int)time(NULL));
	
	// Setup console
	system("title Random Character");
	system("mode con cols=80 lines=40");
	
	// Hide console cursor
	CONSOLE_CURSOR_INFO consoleCursorInfo;
	
	consoleCursorInfo.bVisible = 0;
	consoleCursorInfo.dwSize = 1;
	
	SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &consoleCursorInfo);
}

void Update()
{
	int x = rand() % CONSOLE_WIDTH;
	int y = rand() % CONSOLE_HEIGHT;
	char character = rand() % 26 + 65 + ((rand() & 1) ? + 32 : 0) + rand() % 32;
	char color = rand() % 16;
	
	if (_kbhit())
	{
		character = _getch();
	}
	
	switch (color)
	{
		case 0:
			system("color 0f");
			
			break;
		case 1:
			system("color 07");
			
			break;
		case 2:
			system("color 0b");
			
			break;
		case 3:
			system("color 0a");
			
			break;
	}
	
	Gotoxy(x, y);
	printf("%c", character);
}

void Gotoxy(int x, int y)
{
	COORD position = { x, y };
	
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), position);
}
