#pragma once

#include <Windows.h>
#define IO_READ_REQUEST CTL_CODE(FILE_DEVICE_UNKNOWN, 0xF0A, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)
#define IO_WRITE_REQUEST CTL_CODE(FILE_DEVICE_UNKNOWN, 0xF0B, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)
#define IO_GET_ID_REQUEST CTL_CODE(FILE_DEVICE_UNKNOWN, 0xF0C, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)
#define IO_GET_MODULE_REQUEST CTL_CODE(FILE_DEVICE_UNKNOWN, 0xF0D, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)

typedef struct _KERNEL_READ_REQUEST
{
	ULONG ProcessId;

	ULONG Address;
	ULONG Response;
	ULONG Size;

} KERNEL_READ_REQUEST, * PKERNEL_READ_REQUEST;

typedef struct _KERNEL_WRITE_REQUEST
{
	ULONG ProcessId;

	ULONG Address;
	ULONG Value;
	ULONG Size;

} KERNEL_WRITE_REQUEST, * PKERNEL_WRITE_REQUEST;

class IROG 
{
public:
	IROG(LPCSTR RegistryPath);
	~IROG();

	template <typename type>
	type RVM(ULONG ProcessId, ULONG ReadAddress, SIZE_T Size)
	{
		if (hDriver == INVALID_HANDLE_VALUE)
			return (type)false;

		DWORD Return, Bytes;
		KERNEL_READ_REQUEST ReadRequest;

		ReadRequest.ProcessId = ProcessId;
		ReadRequest.Address = ReadAddress;
		ReadRequest.Size = Size;

		if (DeviceIoControl(hDriver, IO_READ_REQUEST, &ReadRequest, sizeof(ReadRequest), &ReadRequest, sizeof(ReadRequest), 0, 0))
			return (type)ReadRequest.Response;
		else
			return (type)false;
	}

	bool WVM(ULONG ProcessId, ULONG WriteAddress, ULONG WriteValue, SIZE_T WriteSize);
	DWORD GETPID();
	DWORD GETMOD();
private:
	HANDLE hDriver = NULL;
};