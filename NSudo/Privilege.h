//获取令牌权限(适用于令牌)
bool GetToken(HANDLE TokenHandle, LPCWSTR lpName)
{
	bool bRet = false;
	if (TokenHandle != INVALID_HANDLE_VALUE)
	{
		LUID Luid;
		if (LookupPrivilegeValueW(NULL, lpName, &Luid))
		{
			TOKEN_PRIVILEGES TokenPrivileges;

			TokenPrivileges.PrivilegeCount = 1;
			TokenPrivileges.Privileges[0].Luid = Luid;
			TokenPrivileges.Privileges[0].Attributes = SE_PRIVILEGE_ENABLED;

			if (AdjustTokenPrivileges(TokenHandle, FALSE, &TokenPrivileges, sizeof(TokenPrivileges), NULL, NULL)) bRet = true;
		}
	}
	return bRet;
}

//获取令牌权限(适用于进程)
bool GetPrivilege(HANDLE ProcessHandle, LPCWSTR lpName)
{
	bool bRet = false;
	HANDLE hCurrentProcessToken;
	if (OpenProcessToken(ProcessHandle, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, &hCurrentProcessToken))
	{
		if (GetToken(hCurrentProcessToken, lpName)) bRet = true;
		CloseHandle(hCurrentProcessToken);
	}
	return bRet;
}

//一键获取全部权限令牌(适用于令牌)
void GetAllTokens(HANDLE TokenHandle)
{
	GetToken(TokenHandle, SE_CREATE_TOKEN_NAME);
	GetToken(TokenHandle, SE_ASSIGNPRIMARYTOKEN_NAME);
	GetToken(TokenHandle, SE_LOCK_MEMORY_NAME);
	GetToken(TokenHandle, SE_INCREASE_QUOTA_NAME);
	GetToken(TokenHandle, SE_UNSOLICITED_INPUT_NAME);
	GetToken(TokenHandle, SE_MACHINE_ACCOUNT_NAME);
	GetToken(TokenHandle, SE_TCB_NAME);
	GetToken(TokenHandle, SE_SECURITY_NAME);
	GetToken(TokenHandle, SE_TAKE_OWNERSHIP_NAME);
	GetToken(TokenHandle, SE_LOAD_DRIVER_NAME);
	GetToken(TokenHandle, SE_SYSTEM_PROFILE_NAME);
	GetToken(TokenHandle, SE_SYSTEMTIME_NAME);
	GetToken(TokenHandle, SE_PROF_SINGLE_PROCESS_NAME);
	GetToken(TokenHandle, SE_INC_BASE_PRIORITY_NAME);
	GetToken(TokenHandle, SE_CREATE_PAGEFILE_NAME);
	GetToken(TokenHandle, SE_CREATE_PERMANENT_NAME);
	GetToken(TokenHandle, SE_BACKUP_NAME);
	GetToken(TokenHandle, SE_RESTORE_NAME);
	GetToken(TokenHandle, SE_SHUTDOWN_NAME);
	GetToken(TokenHandle, SE_DEBUG_NAME);
	GetToken(TokenHandle, SE_AUDIT_NAME);
	GetToken(TokenHandle, SE_SYSTEM_ENVIRONMENT_NAME);
	GetToken(TokenHandle, SE_CHANGE_NOTIFY_NAME);
	GetToken(TokenHandle, SE_REMOTE_SHUTDOWN_NAME);
	GetToken(TokenHandle, SE_UNDOCK_NAME);
	GetToken(TokenHandle, SE_SYNC_AGENT_NAME);
	GetToken(TokenHandle, SE_ENABLE_DELEGATION_NAME);
	GetToken(TokenHandle, SE_MANAGE_VOLUME_NAME);
	GetToken(TokenHandle, SE_IMPERSONATE_NAME);
	GetToken(TokenHandle, SE_CREATE_GLOBAL_NAME);
	GetToken(TokenHandle, SE_TRUSTED_CREDMAN_ACCESS_NAME);
	GetToken(TokenHandle, SE_RELABEL_NAME);
	GetToken(TokenHandle, SE_INC_WORKING_SET_NAME);
	GetToken(TokenHandle, SE_TIME_ZONE_NAME);
	GetToken(TokenHandle, SE_CREATE_SYMBOLIC_LINK_NAME);
}