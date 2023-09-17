// kGlow.Rad.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "C:\Users\Alex\Documents\VS Projects\Hybrid\kGlow\Ext\kGlow.Bhop\kGlow.Bhop\Header.h"
#include "C:\Users\Alex\Documents\VS Projects\Hybrid\kGlow\Interface\kGlow.Interface\kGlow.Interface\class.hpp"
#include "C:\Users\Alex\Documents\VS Projects\Hybrid\kGlow\Interface\kGlow.Interface\kGlow.Interface\class.cpp"
#include <iostream>

using namespace std;

int main()
{
    IGLOW kDriver = IGLOW("\\\\.\\glow");

    DWORD PID = kDriver.GETPID();
    DWORD MOD = kDriver.GETMOD();

    DWORD LocalPlayer = kDriver.RVM<DWORD>(PID, MOD + signatures::dwLocalPlayer, sizeof(DWORD));
    DWORD LocalTeam = kDriver.RVM<DWORD>(PID, LocalPlayer + netvars::m_iTeamNum, sizeof(DWORD));

    while (true)
    {
        for (int i = 1; i <= 32; i++)
        {
            DWORD Player = kDriver.RVM<DWORD>(PID, MOD + signatures::dwEntityList + (i * 0x10), sizeof(DWORD));
            DWORD PlayerTeam = kDriver.RVM<DWORD>(PID, Player + netvars::m_iTeamNum, sizeof(DWORD));
            BOOL PlayerDormant = kDriver.RVM<BOOL>(PID, Player + signatures::m_bDormant, sizeof(BOOL));
            BOOL PlayerSpotted = kDriver.RVM<DWORD>(PID, Player + netvars::m_bSpotted, sizeof(BOOL));

            if (!PlayerDormant && PlayerTeam != LocalTeam)
            {
                if (!PlayerSpotted)
                    kDriver.WVM<BOOL>(PID, Player + netvars::m_bSpotted, true, sizeof(BOOL));
            }

        }
    }
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
