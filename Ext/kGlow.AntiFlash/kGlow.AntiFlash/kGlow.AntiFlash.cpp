// kGlow.AntiFlash.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "class.hpp"
#include "C:\Users\Alex\Documents\VS Projects\Hybrid\Draft\kGlow\Ext\kGlow.Bhop\kGlow.Bhop\Header.h"


using namespace std;

int main()
{
    int flashDur = 0;

    IGLOW kDriver = IGLOW("\\\\.\\glow");

    system("pause");

    DWORD PID = kDriver.GETPID();
    DWORD CLIENT = kDriver.GETCLIENT();

    DWORD LocalPlayer = kDriver.RVM<DWORD>(PID, CLIENT + signatures::dwLocalPlayer, sizeof(DWORD));

    while (true)
    {
        flashDur = kDriver.RVM<int>(PID, LocalPlayer + netvars::m_flFlashDuration, sizeof(int));
        if (flashDur > 0)
            kDriver.WVM<int>(PID, LocalPlayer + netvars::m_flFlashDuration, 0, sizeof(int));

        Sleep(1);
    }
}
