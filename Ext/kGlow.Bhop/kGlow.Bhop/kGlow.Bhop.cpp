#include <iostream>
#include "C:\Users\Alex\Documents\VS Projects\Hybrid\kGlow\Interface\kGlow.Interface\kGlow.Interface\class.hpp"
#include "C:\Users\Alex\Documents\VS Projects\Hybrid\kGlow\Interface\kGlow.Interface\kGlow.Interface\class.cpp"
#include "Header.h"

using namespace std;

int main()
{
    IGLOW kDriver = IGLOW("\\\\.\\glow");

    system("pause");

    DWORD PID = kDriver.GETPID();
    DWORD MOD = kDriver.GETMOD();

    DWORD LocalPlayer = kDriver.RVM<DWORD>(PID, MOD + signatures::dwLocalPlayer, sizeof(DWORD));

    while (true)
    {
        DWORD InGround = kDriver.RVM<DWORD>(PID, LocalPlayer + netvars::m_fFlags, sizeof(DWORD));

        if ((GetAsyncKeyState(VK_SPACE) & 0x8000) && (InGround & 1 == 1))
        {
            kDriver.WVM<__int64>(PID, MOD + signatures::dwForceJump, 0x5, 8);
            Sleep(50);
            kDriver.WVM<__int64>(PID, MOD + signatures::dwForceJump, 0x4, 8);
        }
        Sleep(10);
    }

}
