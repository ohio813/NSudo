// stdafx.h : 标准系统包含文件的包含文件，
// 或是经常使用但不常更改的
// 特定于项目的包含文件
//

#pragma once

#include "targetver.h"

// Windows 头文件: 
#include <windows.h>

// C 运行时头文件
#include <stdlib.h>
#include <malloc.h>
#include <memory.h>
#include <tchar.h>

#include <strsafe.h>

// TODO:  在此处引用程序需要的其他头文件
#include <Tlhelp32.h>
#include <Shellapi.h>
#include <winsvc.h>

#include<Userenv.h>
#pragma comment(lib,"Userenv.lib")

#include <CommCtrl.h>
#pragma comment(lib,"comctl32.lib")

#pragma comment(linker,"/manifestdependency:\"type='win32' name='Microsoft.Windows.Common-Controls' version='6.0.0.0' processorArchitecture='*' publicKeyToken='6595b64144ccf1df' language='*'\"")

#include <Shlwapi.h>
#pragma comment (lib, "Shlwapi.lib")

/*
int hr = MessageBoxW(NULL,
L"是否允许通过NSudo调用这个程序\n"
L"\n"
L"命令行: cmd.exe /k \n"
L"\n"
L"提示:如果这个程序不是你主动调用的话，请点击取消\n",
L"NSudo 2.2 (Build 861) By Mouri_Naruto",
MB_YESNO | MB_ICONINFORMATION);
*/