//Mouri_Naruto NSudo 2.2 (Build 861)
//(C) CopyRight 2015 Mouri_Naruto

#include "stdafx.h"
#include "NSudo.h"

#define NSudo_Title L"NSudo 2.2 (Build 861) By Mouri_Naruto"
#define NSudo_HelpText L"NSudo [选项]\n\n选项:\n-TI 以System权限(具有TrustedInstaller令牌)运行命令提示符\n-System 以System权限运行命令提示符\n-Help 弹出命令行帮助"

#define ReturnMessage(lpText) MessageBoxW(NULL, (lpText), NSudo_Title, NULL)

#define StrLenW(str) sizeof(str) / 2 - 1

void GetSystemPrivilege(LPWSTR szCMDLine);
void GetTIToken(LPWSTR szCMDLine);
void CreateCMDShell(LPCWSTR lpConsoleTitle);

#include "Privilege.h"

int WINAPI wWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPTSTR lpCmdLine, int nCmdShow)
{	
	if (!GetPrivilege(GetCurrentProcess(),SE_DEBUG_NAME))
	{
		ReturnMessage(L"进程调试权限获取失败");
		return -1;
	}

	//内部命令行参数
	if (StrCmpNIW(L"-TiShell", lpCmdLine, StrLenW(L"-TiShell")) == 0)
	{
		wchar_t szCMDLine[260];
		GetModuleFileNameW(NULL, szCMDLine, 260);
		wcscat_s(szCMDLine, 260, L" -GetTiShell");
		GetTIToken(szCMDLine);
		ExitProcess(0);
	}
	else if (StrCmpNIW(L"-GetSystemShell", lpCmdLine, StrLenW(L"-GetSystemShell")) == 0)
	{
		CreateCMDShell(L"NSudo - [System]");
	}
	else if (StrCmpNIW(L"-GetTiShell", lpCmdLine, StrLenW(L"-GetTiShell")) == 0)
	{
		CreateCMDShell(L"NSudo - [System With TrustedInstaller Token]");
	}

	//公开的命令行参数
	if (StrCmpNIW(L"-TI", lpCmdLine, StrLenW(L"-TI")) == 0)
	{
		wchar_t szCMDLine[260];
		GetModuleFileNameW(NULL, szCMDLine, 260);
		StringCbCatW(szCMDLine, sizeof(szCMDLine), L" -TiShell");
		GetSystemPrivilege(szCMDLine);
		ExitProcess(0);
	}
	else if (StrCmpNIW(L"-System", lpCmdLine, StrLenW(L"-System")) == 0)
	{
		wchar_t szCMDLine[260];
		GetModuleFileNameW(NULL, szCMDLine, 260);
		StringCbCatW(szCMDLine, sizeof(szCMDLine), L" -GetSystemShell");
		GetSystemPrivilege(szCMDLine);
		ExitProcess(0);
	}
	else if (StrCmpNIW(L"-Help", lpCmdLine, StrLenW(L"-Help")) == 0)
	{
		ReturnMessage(NSudo_HelpText);
		ExitProcess(0);
	}
	else
	{
		int nButtonPressed = 0, nRadioButton = 0;
		TASKDIALOGCONFIG config = { 0 };
		const TASKDIALOG_BUTTON buttons[] = {
			{ 101, L"以所选权限运行命令提示符(&C)" },
			{ 102, L"命令行帮助(&H)" },
		};
		const TASKDIALOG_BUTTON choosebuttons[] = {
			{ 201, L"System权限(具有TrustedInstaller令牌)(&T)" },
			{ 202, L"仅System权限(&S)" },
		};

		config.dwFlags = TDF_USE_HICON_MAIN | TDF_USE_HICON_FOOTER | TDF_EXPAND_FOOTER_AREA | TDF_ALLOW_DIALOG_CANCELLATION;
		config.cbSize = sizeof(config);
		config.pszWindowTitle = NSudo_Title;
		config.cRadioButtons = ARRAYSIZE(choosebuttons);
		config.pRadioButtons = choosebuttons;
		config.pszMainInstruction = L"请选择你需要的权限";
		config.hInstance = hInstance;
		config.cButtons = ARRAYSIZE(buttons);
		config.pButtons = buttons;
		config.hMainIcon = LoadIconW(hInstance, MAKEINTRESOURCE(IDI_NSUDO));
		LoadIconWithScaleDown(NULL, IDI_WARNING,GetSystemMetrics(SM_CXSMICON), GetSystemMetrics(SM_CYSMICON),&config.hFooterIcon);
		config.pszFooter = L"警告：使用本工具需要有一定的计算机基础";

		TaskDialogIndirect(&config, &nButtonPressed, &nRadioButton, NULL);

		switch (nButtonPressed)
		{
		case 101:
			if (nRadioButton == 201)
			{
				wchar_t szCMDLine[260];
				GetModuleFileNameW(NULL, szCMDLine, 260);
				StringCbCatW(szCMDLine, sizeof(szCMDLine), L" -TiShell");
				GetSystemPrivilege(szCMDLine);
			}
			else
			{
				wchar_t szCMDLine[260];
				GetModuleFileNameW(NULL, szCMDLine, 260);
				StringCbCatW(szCMDLine, sizeof(szCMDLine), L" -GetSystemShell");
				GetSystemPrivilege(szCMDLine);
			}
			ExitProcess(0);
		case 102:
			ReturnMessage(NSudo_HelpText);
			_tWinMain(hInstance, hPrevInstance, lpCmdLine, nCmdShow);
		default:
			break;
		}
	}
	
	return 0;
}

void GetSystemPrivilege(LPWSTR szCMDLine)
{
	DWORD dwUserSessionId; //用户会话ID
	DWORD dwWinLogonPID = -1; //winlogon.exe的ProcessID

	if ((dwUserSessionId = WTSGetActiveConsoleSessionId()) == 0xFFFFFFFF) //获得用户会话ID
	{
		ReturnMessage( L"获得用户会话ID失败");
		return;
	}

	PROCESSENTRY32W ProcessEntry;
	ProcessEntry.dwSize = sizeof(PROCESSENTRY32W);
	HANDLE hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0); //调用CreateToolhelp32Snapshot快照所有进程
	if (hSnapshot == INVALID_HANDLE_VALUE)
	{
		ReturnMessage(L"CreateToolhelp32Snapshot调用失败");
		return;
	}

	if (Process32FirstW(hSnapshot, &ProcessEntry)) //遍历进程
	{
		do
		{
			if (StrCmpNIW(L"winlogon.exe", ProcessEntry.szExeFile, StrLenW(L"winlogon.exe")) == 0) //寻找winlogon进程
			{
				DWORD dwSessionID;
				if (ProcessIdToSessionId(ProcessEntry.th32ProcessID, &dwSessionID)) //获取winlogon的会话ID
				{
					if (dwSessionID != dwUserSessionId) continue; //判断是否是当前用户ID
					dwWinLogonPID = ProcessEntry.th32ProcessID;
					break;
				}
			}
		} while (Process32NextW(hSnapshot, &ProcessEntry));
	}
	CloseHandle(hSnapshot);

	if (dwWinLogonPID == -1)
	{
		ReturnMessage(L"winlogon.exe进程PID获取失败");
		return;
	}

	HANDLE hProc = OpenProcess(PROCESS_ALL_ACCESS, FALSE, dwWinLogonPID);
	if (hProc != NULL)
	{
		HANDLE hToken, hDupToken;
		if (OpenProcessToken(hProc, TOKEN_DUPLICATE | TOKEN_QUERY, &hToken))
		{
			if (DuplicateTokenEx(hToken, TOKEN_ALL_ACCESS, NULL, SecurityIdentification, TokenPrimary, &hDupToken))
			{
				LPVOID lpEnv; //环境块
				if (CreateEnvironmentBlock(&lpEnv, hToken, 1))
				{
					GetAllTokens(hDupToken);
					
					STARTUPINFOW StartupInfo = { 0 };
					PROCESS_INFORMATION ProcessInfo = { 0 };
					StartupInfo.lpDesktop = L"WinSta0\\Default";
					if (!CreateProcessWithTokenW(
						hDupToken,
						LOGON_WITH_PROFILE,
						NULL,
						szCMDLine,
						CREATE_NEW_CONSOLE | CREATE_UNICODE_ENVIRONMENT,
						lpEnv,
						NULL,
						&StartupInfo,
						&ProcessInfo))
					{
						if (!CreateProcessAsUserW(hDupToken,
							NULL,
							szCMDLine,
							NULL,
							NULL,
							NULL,
							CREATE_NEW_CONSOLE | CREATE_UNICODE_ENVIRONMENT,
							lpEnv,
							NULL,
							&StartupInfo,
							&ProcessInfo))
						{
							ReturnMessage(L"进程创建失败");
						}
					}
					DestroyEnvironmentBlock(lpEnv);
				}
				else ReturnMessage(L"winlogon.exe进程环境块创建失败");
				CloseHandle(hDupToken);
			}
			else ReturnMessage(L"winlogon.exe进程句柄令牌复制失败");
			CloseHandle(hToken);
		}
		else ReturnMessage(L"winlogon.exe进程句柄令牌打开失败");
		CloseHandle(hProc);
	}
	else ReturnMessage(L"winlogon.exe进程句柄打开失败");
}

void GetTIToken(LPWSTR szCMDLine)
{
	SC_HANDLE hSC = OpenSCManagerW(NULL, NULL, GENERIC_EXECUTE);
	if (hSC != NULL)
	{
		SC_HANDLE hSvc = OpenServiceW(hSC, L"TrustedInstaller", SERVICE_START | SERVICE_QUERY_STATUS | SERVICE_STOP);
		if (hSvc != NULL)
		{
			SERVICE_STATUS status;
			if (QueryServiceStatus(hSvc, &status))
			{
				if (status.dwCurrentState == SERVICE_STOPPED)
				{
					// 启动服务
					if (StartServiceW(hSvc, NULL, NULL) == FALSE)
					{
						ReturnMessage(L"TrustedInstaller服务启动失败");
					}
					// 等待服务启动
					while (::QueryServiceStatus(hSvc, &status) == TRUE)
					{
						Sleep(status.dwWaitHint);
						if (status.dwCurrentState == SERVICE_RUNNING)
						{
							break;
						}
					}
				}
			}
			CloseServiceHandle(hSvc);
		}
		CloseServiceHandle(hSC);
	}

	DWORD dwTIPID = -1; //winlogon.exe的ProcessID

	PROCESSENTRY32W ProcessEntry;
	ProcessEntry.dwSize = sizeof(PROCESSENTRY32W);
	HANDLE hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0); //调用CreateToolhelp32Snapshot快照所有进程
	if (hSnapshot == INVALID_HANDLE_VALUE)
	{
		ReturnMessage(L"CreateToolhelp32Snapshot调用失败");
		return;
	}

	if (Process32FirstW(hSnapshot, &ProcessEntry)) //便利进程
	{
		do
		{
			if (StrCmpNIW(L"TrustedInstaller.exe", ProcessEntry.szExeFile, StrLenW(L"TrustedInstaller.exe")) == 0) //寻找TrustedInstaller进程
			{
				dwTIPID = ProcessEntry.th32ProcessID;
				break;
			}
		} while (Process32NextW(hSnapshot, &ProcessEntry));
	}
	CloseHandle(hSnapshot);

	if (dwTIPID == -1)
	{
		ReturnMessage(L"TrustedInstaller.exe进程PID获取失败");
		return;
	}

	HANDLE hProc = OpenProcess(PROCESS_ALL_ACCESS, FALSE, dwTIPID);
	if (hProc != NULL)
	{
		HANDLE hToken, hDupToken;
		if (OpenProcessToken(hProc, TOKEN_DUPLICATE | TOKEN_QUERY, &hToken))
		{
			if (DuplicateTokenEx(hToken, TOKEN_ALL_ACCESS, NULL, SecurityIdentification, TokenPrimary, &hDupToken))
			{
				LPVOID lpEnv; //环境块
				if (CreateEnvironmentBlock(&lpEnv, hToken, 1))
				{
					GetAllTokens(hDupToken);
					
					STARTUPINFOW StartupInfo = { 0 };
					PROCESS_INFORMATION ProcessInfo = { 0 };
					StartupInfo.lpDesktop = L"WinSta0\\Default";
					if (!CreateProcessWithTokenW(
						hDupToken,
						LOGON_WITH_PROFILE,
						NULL,
						szCMDLine,
						CREATE_NEW_CONSOLE | CREATE_UNICODE_ENVIRONMENT,
						lpEnv,
						NULL,
						&StartupInfo,
						&ProcessInfo))
					{
						if (!CreateProcessAsUserW(hDupToken,
							NULL,
							szCMDLine,
							NULL,
							NULL,
							NULL,
							CREATE_NEW_CONSOLE | CREATE_UNICODE_ENVIRONMENT,
							lpEnv,
							NULL,
							&StartupInfo,
							&ProcessInfo))
						{						
							ReturnMessage(L"进程创建失败");
						}
					}
					DestroyEnvironmentBlock(lpEnv);
				}
				else ReturnMessage(L"TrustedInstaller.exe进程环境块创建失败");
				CloseHandle(hDupToken);
			}
			else ReturnMessage(L"TrustedInstaller.exe进程句柄令牌复制失败");
			CloseHandle(hToken);
		}
		else ReturnMessage(L"TrustedInstaller.exe进程句柄令牌打开失败");
		CloseHandle(hProc);
	}
	else ReturnMessage(L"TrustedInstaller.exe进程句柄打开失败");
}



//创建命令提示符窗口
void CreateCMDShell(LPCWSTR lpConsoleTitle)
{
	AllocConsole(); //开启控制台

	HANDLE hOut = GetStdHandle(STD_OUTPUT_HANDLE); // 获取控制台句柄 

	HICON hIcon = LoadIconW(GetModuleHandleW(NULL), MAKEINTRESOURCE(IDI_NSUDO));//获取图标句柄
	SendMessageW(GetConsoleWindow(), WM_SETICON, ICON_SMALL, (LPARAM)hIcon);//设置控制台图标

	SetConsoleTitleW(lpConsoleTitle); // 设置窗口标题 

	COORD size = { 80, 300 };
	SetConsoleScreenBufferSize(hOut, size); // 设置缓冲区大小 

	wchar_t szCMDPath[260];

	GetSystemWindowsDirectoryW(szCMDPath, 260); //获取Windows目录

	if (GetProcAddress(GetModuleHandleW(L"ntdll.dll"), "ZwWow64ReadVirtualMemory64")) //判断是否是64位OS
	{
		StringCbCatW(szCMDPath, sizeof(szCMDPath), L"\\SysNative\\cmd.exe"); //64命令提示符路径
	}
	else
	{
		StringCbCatW(szCMDPath, sizeof(szCMDPath), L"\\System32\\cmd.exe"); //32命令提示符路径
	}

	PROCESS_INFORMATION pi = { 0 };
	STARTUPINFOW si = { 0 };
	si.hStdOutput = hOut;
	CreateProcessW(NULL, szCMDPath, NULL, NULL, FALSE, NULL, NULL, NULL, &si, &pi); //创建CMD

	WaitForSingleObject(pi.hProcess, INFINITE); //等待进程结束

	FreeConsole();

	ExitProcess(0);//退出程序
}