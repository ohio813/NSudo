NSudo - A Powerful System Administration Tool
========================================================================================

This tool is built on raymai97‘s SuperCMD.

Thanks to raymai97, he wrote, "[分享] 超级命令提示符 让你拥有真正的最高权限" gave me great inspiration (he even left the source code for our study, I really admire him)

I modify his source code and delete duplicate parts; so you can use a file you can directly open the TrustedInstaller permissions command prompt.


The following quote raymai97 about TrustedInstaller
========================================================================================
[QUOTE]TrustedInstaller is the Windows Update and other system components need to modify the file, the use of "agent".


TI permissions are very high ~ ~ SYSTEM is even higher than the Windows version of the ROOT permissions ~
TI CMD mode allows you to modify / damage NTFS permissions settings, to operate the system files, rename, delete, such as replacement...... Has been verified can be successfully modified files including explorer.exe, shell32.exe, 


iexplore.exe.
Using the TI mode of the CMD, the program will automatically start the TI permission. So you can start the third party file manager you like with it, such as 7zFM. Note that, explorer does not support TI mode, it will not function 


properly.
You may want to ask, modify the NTFS permissions settings not good? There are many online "button to change the owner" "key to obtain permission" ~
You know, NTFS permissions setting is used to prevent your system files are blind to change. The vast majority of people are often in the modify permissions and file, no recovery permissions settings, so after the other programs can be 


directly to the file modification!
If it is the default NTFS setting permissions, even run as administrator of the program, also need to use quite a lot of code to let yourself have permissions, modify the relevant documents.
The Win8 WindowsApps folder is a typical example. If you modify the permissions, not to go back to, will not open Apps (flash back) risk, serious will all Apps are not open to!
Well, you said you have to manually change the file permissions, and then modify the permissions, then change it back...... Just think, in order to modify a file system, so the trouble. If more than one file system?
So I think, the direct use of CMD with TI authority, and then with the other third parties file manager (such as 7zFM), than to modify the NTFS permission set is more convenient, fast, safe ~
[/QUOTE]

What's New
========================================================================================
[QUOTE]
NSudo 2016


1.Add the multi-language support(zh-cn,zh-tw,en-us,ja,jp)
  Thank Eugene Wang J.y for the zh-tw translation.
  Thank Microsoft_Mars for the ja-jp translation.
2.Rewrite All Codes

[/QUOTE]

Method of use
========================================================================================
Double click the NSudo.exe according to the prompts

Command line options


[QUOTE]

NSudo 2016(Build 1208)
© 2016 M2-Team. All rights reserved.

Alipay account for donation: wxh32lkk@live.cn
Thanks for boyangpangzi, cjy__05, mhxkx, NotePad, tangmigoId, wondersnefu, xy137425740 and 月光光.(Sorted by the first letter.)

Format: NSudoC [ -U ] [ -P ] [ -M ] Command line or ShortCut Command
  -U:[ T | S | C | P | D ] User
  T TrustedInstaller
  S System
  C Current User
  P Current Process
  D Current Process (Drop right)

  -P:[ E | D ] Privilege
  E Enable All Privileges
  D Disable All Privileges
  PS: If you want to use the default privileges, please do not include the -P parameter.

  -M:[ S | H | M | L ] Integrity Level
  S System
  H High
  M Medium
  L Low
  PS: If you want to use the default Integrity Level, please do not include the -M parameter

  -? Show this content

  Example：If you want to run Command Prompt with TrustedInstaller , enable all privileges and the default Integrity Level
                NSudo -U:T -P:E cmd

[/QUOTE]

The matters needing attention
========================================================================================
Warning: If you think BIOS is a new plant-based fuel, NSudo may not be right for you.


The license agreement
========================================================================================
This tool uses MIT License, anyone can modify my tools (front mention a nice name, because it's not my tools)


Have a good time -- M2-Team
===================================================================================