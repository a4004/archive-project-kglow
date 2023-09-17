#include "class.h"

extern "C" __declspec(dllexport) DWORD ReadInt32(ULONG PID, ULONG ADDR)
{
	IROG kDriver = IROG("\\\\.\\rog");
	return kDriver.RVM<DWORD>(PID, ADDR, sizeof(DWORD));
}

extern "C" __declspec(dllexport) ULONG ReadInt64(ULONG PID, ULONG ADDR)
{
	IROG kDriver = IROG("\\\\.\\rog");
	return kDriver.RVM<ULONG>(PID, ADDR, sizeof(ULONG));
}

extern "C" __declspec(dllexport) bool ReadBool(ULONG PID, ULONG ADDR)
{
	IROG kDriver = IROG("\\\\.\\rog");
	return kDriver.RVM<bool>(PID, ADDR, sizeof(bool));
}

extern "C" __declspec(dllexport) bool WriteMemory(ULONG PID, ULONG ADDR, ULONG VAL)
{
	IROG kDriver = IROG("\\\\.\\rog");
	return kDriver.WVM(PID, ADDR, VAL, sizeof(VAL));
}

extern "C" __declspec(dllexport) DWORD GetProcessID()
{
	IROG kDriver = IROG("\\\\.\\rog");
	return kDriver.GETPID();
}

extern "C" __declspec(dllexport) DWORD GetModuleAddress()
{
	IROG kDriver = IROG("\\\\.\\rog");
	return kDriver.GETMOD();
}

extern "C" __declspec(dllexport) VOID DoGlow()
{
	IROG kDriver = IROG("\\\\.\\rog");

	int PID = kDriver.GETPID();
	int MOD = kDriver.GETMOD();

	int dwLocalPlayer = 0xD3DBEC;
	int m_iTeamNum = 0xF4;
	int dwEntityList = 0x4D523EC;
	int m_bDormant = 0xED;
    int m_iGlowIndex = 0xA438;
	int dwGlowObjectManager = 0x529A248;

	while (true) 
	{
		int address;
		int i = 1;

		do
		{
			address = MOD + dwLocalPlayer;
			int Player = kDriver.RVM<DWORD>(PID, address, sizeof(DWORD));

			address = Player + m_iTeamNum;
			int MyTeam = kDriver.RVM<DWORD>(PID, address, sizeof(DWORD));

			address = MOD + dwEntityList + (i - 1) * 0x10;
			int EntityList = kDriver.RVM<DWORD>(PID, address, sizeof(DWORD));

			address = EntityList + m_iTeamNum;
			int HisTeam = kDriver.RVM<DWORD>(PID, address, sizeof(DWORD));

			address = EntityList + m_bDormant;
			bool IsDormant = kDriver.RVM<bool>(PID, address, sizeof(bool));
			if (!IsDormant)
			{
				address = EntityList + m_iGlowIndex;
				int GlowIndex = kDriver.RVM<DWORD>(PID, address, sizeof(DWORD));

				if (MyTeam == HisTeam)
				{
					address = MOD + dwGlowObjectManager;
					int GlowObject = kDriver.RVM<DWORD>(PID, address, sizeof(DWORD));

					int calculation = GlowIndex * 0x38 + 0x4;
					int current = GlowObject + calculation;
					kDriver.WVM(PID, current, 0, sizeof(float));

				    calculation = GlowIndex * 0x38 + 0x8;
					current = GlowObject + calculation;
					kDriver.WVM(PID, current, 1, sizeof(float));

					calculation = GlowIndex * 0x38 + 0xC;
					current = GlowObject + calculation;
					kDriver.WVM(PID, current, 0, sizeof(float));

					calculation = GlowIndex * 0x38 + 0x10;
					current = GlowObject + calculation;
					kDriver.WVM(PID, current, 1, sizeof(float));

					calculation = GlowIndex * 0x38 + 0x24;
				    current = GlowObject + calculation;
					kDriver.WVM(PID, current, 1, sizeof(bool));

				    calculation = GlowIndex * 0x38 + 0x25;
					current = GlowObject + calculation;
					kDriver.WVM(PID, current, 0, sizeof(bool));
				}
				else
				{
					address = MOD + dwGlowObjectManager;
					int GlowObject = kDriver.RVM<DWORD>(PID, address, sizeof(DWORD));

					int calculation = GlowIndex * 0x38 + 0x4;
					int current = GlowObject + calculation;
					kDriver.WVM(PID, current, 1, sizeof(float));

					calculation = GlowIndex * 0x38 + 0x8;
					current = GlowObject + calculation;
					kDriver.WVM(PID, current, 0, sizeof(float));

					calculation = GlowIndex * 0x38 + 0xC;
					current = GlowObject + calculation;
					kDriver.WVM(PID, current, 0, sizeof(float));

					calculation = GlowIndex * 0x38 + 0x10;
				    current = GlowObject + calculation;
					kDriver.WVM(PID, current, 1, sizeof(float));

					calculation = GlowIndex * 0x38 + 0x24;
					current = GlowObject + calculation;
					kDriver.WVM(PID, current, 1, sizeof(bool));

					calculation = GlowIndex * 0x38 + 0x25;
					current = GlowObject + calculation;
					kDriver.WVM(PID, current, 0, sizeof(bool));
				}
			}
			i++;
		} while (i < 65);
	}
}

