// CSGO-TEST.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "class.h"
#include "stuff.hpp"

using namespace std;

int main()
{
    cout << "Program Started.\n";

	IROG kDriver = IROG("\\\\.\\rog");

	DWORD PID = kDriver.GETPID();
	DWORD MOD = kDriver.GETMOD();

	/* OLD STUFF
	DWORD dwLocalPlayer = 0xD3DBEC;
	DWORD m_iTeamNum = 0xF4;
	DWORD dwEntityList = 0x4D523EC;
	DWORD m_bDormant = 0xED;
	DWORD m_iGlowIndex = 0xA438;
	DWORD dwGlowObjectManager = 0x529A248;
	*/

	system("pause");

	while (true) 
	{
		//system("cls");

		DWORD LocalPlayer = kDriver.RVM<DWORD>(PID, MOD + signatures::dwLocalPlayer, sizeof(DWORD));
		//cout << "LocalPlayer: 0x" << hex << LocalPlayer << endl;
	    //cout << "LocalPlayer Addr: 0x" << hex << MOD + signatures::dwLocalPlayer << endl;

		DWORD lpTeam = kDriver.RVM<DWORD>(PID, LocalPlayer + netvars::m_iTeamNum, sizeof(DWORD));
		//cout << "LocalTeam: 0x" << hex << lpTeam << endl;
	    //cout << "LocalTeam Addr: 0x" << hex << LocalPlayer + netvars::m_iTeamNum << endl;

		DWORD GlowObject = kDriver.RVM<DWORD>(PID, MOD + signatures::dwGlowObjectManager, sizeof(DWORD));
		//cout << "GlowObject: 0x" << hex << GlowObject << endl;
		//cout << "GlowObject Addr: 0x" << hex << MOD + signatures::dwGlowObjectManager << endl;

		if (lpTeam == 0x1 || lpTeam == 0x0)
			continue;

		for (int i = 1; i <= 32; i++)
		{
			//system("cls");

			DWORD Entity = kDriver.RVM<DWORD>(PID, MOD + signatures::dwEntityList + i * 0x10, sizeof(DWORD));
			//cout << "Entity: 0x" << hex << Entity << endl;
			//cout << "Entity Addr: 0x" << hex << MOD + signatures::dwEntityList + i * 0x10 << endl;

			if (Entity)
			{
				DWORD eTeam = kDriver.RVM<DWORD>(PID, Entity + netvars::m_iTeamNum, sizeof(DWORD));
				//cout << "Team: " << dec << eTeam << endl;
				//cout << "Team Addr: 0x" << hex << Entity + netvars::m_iTeamNum << endl;

				DWORD eGlow = kDriver.RVM<DWORD>(PID, Entity + netvars::m_iGlowIndex, sizeof(DWORD));
				//cout << "Glow: 0x" << hex << eGlow << endl;
				//cout << "Glow Addr: 0x" << hex << Entity + netvars::m_iGlowIndex << endl;

				BOOL eDormant = kDriver.RVM<BOOL>(PID, Entity + signatures::m_bDormant, sizeof(BOOL));
				//cout << "Dormant: 0x" << hex << eDormant << endl;
				//cout << "Dormant Addr: 0x" << hex << Entity + signatures::m_bDormant << endl;

				if (eDormant)
					continue;

				if (lpTeam == eTeam)
				{
					//cout << "- - - - - MY TEAM - - - - -" << endl;

					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x4, 0, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x8, 1, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0xC, 0, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x10, 0.7f, sizeof(FLOAT));
					//kDriver.WVM<DWORD>(PID, GlowObject + eGlow * 0x38 + 0x24, 1, sizeof(DWORD));
					kDriver.WVM<BOOL>(PID, GlowObject + eGlow * 0x38 + 0x24, true, sizeof(BOOL));
					kDriver.WVM<BOOL>(PID, GlowObject + eGlow * 0x38 + 0x25, false, sizeof(BOOL));
				}
				else
				{
					//cout << "- - - - - NOT MY TEAM - - - - -" << endl;

					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x4, 1, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x8, 0, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0xC, 0, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x10, 0.7f, sizeof(FLOAT));
					//kDriver.WVM<DWORD>(PID, GlowObject + eGlow * 0x38 + 0x24, 1, sizeof(DWORD));
					kDriver.WVM<BOOL>(PID, GlowObject + eGlow * 0x38 + 0x24, true, sizeof(BOOL));
					kDriver.WVM<BOOL>(PID, GlowObject + eGlow * 0x38 + 0x25, false, sizeof(BOOL));
				}


				/*if (eTeam == 0x2) // Terrorist Team
				{
					//cout << "- - - - - TERRORIST - - - - -" << endl;

					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x4, 1, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x8, 1, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0xC, 0, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x10, 0.7f, sizeof(FLOAT));
					//kDriver.WVM<DWORD>(PID, GlowObject + eGlow * 0x38 + 0x24, 1, sizeof(DWORD));
					kDriver.WVM<BOOL>(PID, GlowObject + eGlow * 0x38 + 0x24, true, sizeof(BOOL));
					kDriver.WVM<BOOL>(PID, GlowObject + eGlow * 0x38 + 0x25, false, sizeof(BOOL));
				}
				if (eTeam == 0x3) // Counter-Terrorist Team
				{
					//cout << "- - - - - COUNTER-TERRORIST - - - - -" << endl;

					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x4, 0, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x8, 0, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0xC, 1, sizeof(FLOAT));
					kDriver.WVM<FLOAT>(PID, GlowObject + eGlow * 0x38 + 0x10, 0.7f, sizeof(FLOAT));
					//kDriver.WVM<DWORD>(PID, GlowObject + eGlow * 0x38 + 0x24, 1, sizeof(DWORD));
					kDriver.WVM<BOOL>(PID, GlowObject + eGlow * 0x38 + 0x24, true, sizeof(BOOL));
					kDriver.WVM<BOOL>(PID, GlowObject + eGlow * 0x38 + 0x25, false, sizeof(BOOL));
				}*/
			}


		}
	}
}



