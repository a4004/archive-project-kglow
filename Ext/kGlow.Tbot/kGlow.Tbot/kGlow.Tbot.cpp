// kGlow.Tbot.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "C:\Users\Alex\Documents\VS Projects\Hybrid\kGlow\Ext\kGlow.Bhop\kGlow.Bhop\Header.h"
#include "C:\Users\Alex\Documents\VS Projects\Hybrid\kGlow\Interface\kGlow.Interface\kGlow.Interface\class.hpp"
#include "C:\Users\Alex\Documents\VS Projects\Hybrid\kGlow\Interface\kGlow.Interface\kGlow.Interface\class.cpp"
#include <iostream>

using namespace std;

struct vector
{
	float x, y, z;
};

IGLOW kDriver = NULL;

DWORD LocalPlayer = NULL;
DWORD PID = NULL;
DWORD WID = NULL;
DWORD MOD = NULL;

/*
bool CheckIfScoped()
{
	return kDriver.RVM<BOOL>(PID, LocalPlayer + netvars::m_bIsScoped, sizeof(BOOL));
}


DWORD GetDelay(float distance)
{
	float delay;

	switch (WID)
	{
	case 262204: delay = 3; break;
	case 7: delay = 3.3; break;
	case 40: delay = 0.15; break;
	case 9: delay = 0.15; break;
	default: delay = 0;
	}

	return delay * distance;
}


void GetWeapon()
{
	DWORD weapon = kDriver.RVM<DWORD>(PID, LocalPlayer + netvars::m_hActiveWeapon, sizeof(DWORD));
	DWORD weaponEnt = kDriver.RVM<DWORD>(PID, MOD + signatures::dwEntityList + ((weapon && 0xFFF) - 1) * 0x10, sizeof(DWORD));
	if (weaponEnt != NULL)
		WID = kDriver.RVM<DWORD>(PID, weaponEnt + netvars::m_iItemDefinitionIndex, sizeof(DWORD));
}

float getDist(DWORD ent)
{
	vector myLoc = kDriver.RVM<vector>(PID, LocalPlayer + netvars::m_vecOrigin, sizeof(vector));
	vector enLoc = kDriver.RVM<vector>(PID, ent + netvars::m_vecOrigin, sizeof(vector));

	return sqrt(pow(myLoc.x - enLoc.x, 2) + pow(myLoc.y - enLoc.y, 2) + pow(myLoc.z - enLoc.z, 2)) * 0.0254;
}*/

int main()
{

	kDriver = IGLOW("\\\\.\\glow");

	system("pause");

	PID = kDriver.GETPID();
	MOD = kDriver.GETMOD();

	LocalPlayer = kDriver.RVM<DWORD>(PID, MOD + signatures::dwLocalPlayer, sizeof(DWORD));
	DWORD LocalTeam = kDriver.RVM<DWORD>(PID, LocalPlayer + netvars::m_iTeamNum, sizeof(DWORD));

	while (true)
	{
		DWORD CrosshairID = kDriver.RVM<DWORD>(PID, LocalPlayer + netvars::m_iCrosshairId, sizeof(DWORD));

		if (CrosshairID != 0 && CrosshairID < 64) 
		{
			DWORD PlayerInCH = kDriver.RVM<DWORD>(PID, MOD + signatures::dwEntityList + ((CrosshairID - 1) * 0x10), sizeof(DWORD));
			DWORD PlayerHealth = kDriver.RVM<DWORD>(PID, PlayerInCH + netvars::m_iHealth, sizeof(DWORD));
			DWORD PlayerTeam = kDriver.RVM<DWORD>(PID, PlayerInCH + netvars::m_iTeamNum, sizeof(DWORD));

			if (LocalTeam != PlayerTeam && PlayerHealth > 0)
			{
				kDriver.WVM<__int64>(PID, MOD + signatures::dwForceAttack, 0x5, 8);
				Sleep(20);
				kDriver.WVM<__int64>(PID, MOD + signatures::dwForceAttack, 0x4, 8);
			}
		}
	}
}




