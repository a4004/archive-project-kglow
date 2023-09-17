#include "class.hpp"

extern "C" __declspec(dllexport) DWORD ReadInteger(DWORD ProcessID, DWORD Address)
{
	IGLOW kDriver = IGLOW("\\\\.\\glow");
	return kDriver.RVM<DWORD>(ProcessID, Address, sizeof(DWORD));
}

extern "C" __declspec(dllexport) BOOL WriteInteger(DWORD ProcessID, DWORD Address, DWORD Value)
{
	IGLOW kDriver = IGLOW("\\\\.\\glow");
	return kDriver.WVM<DWORD>(ProcessID, Address, Value, sizeof(DWORD));
}

extern "C" __declspec(dllexport) BOOL WriteFloat(DWORD ProcessID, DWORD Address, FLOAT Value)
{
	IGLOW kDriver = IGLOW("\\\\.\\glow");
	return kDriver.WVM<FLOAT>(ProcessID, Address, Value, sizeof(FLOAT));
}

extern "C" __declspec(dllexport) BOOL ReadBoolean(DWORD ProcessID, DWORD Address)
{
	IGLOW kDriver = IGLOW("\\\\.\\glow");
	return kDriver.RVM<BOOL>(ProcessID, Address, sizeof(BOOL));
}

extern "C" __declspec(dllexport) bool WriteBoolean(DWORD ProcessID, DWORD Address, BOOL Value)
{
	IGLOW kDriver = IGLOW("\\\\.\\glow");
	return kDriver.WVM<BOOL>(ProcessID, Address, Value, sizeof(BOOL));
}

extern "C" __declspec(dllexport) DWORD GetPID()
{
	IGLOW kDriver = IGLOW("\\\\.\\glow");
	return kDriver.GETPID();
}

extern "C" __declspec(dllexport) DWORD GetModule()
{
	IGLOW kDriver = IGLOW("\\\\.\\glow");
	return kDriver.GETMOD();
}