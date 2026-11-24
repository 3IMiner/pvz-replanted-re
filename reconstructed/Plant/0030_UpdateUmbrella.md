# System.Void UpdateUmbrella()

- 类：`Plant`
- 汇编行数：90

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	cmp dword ptr [rcx+88h],28h
	mov rbx,rcx
	je short 00000001806BE175h
	cmp dword ptr [rcx+88h],29h
	jne short 00000001806BE1A0h
	mov rcx,[rcx+140h]
	test rcx,rcx
	je short 00000001806BE1A6h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806BE1A0h
	movss xmm1,dword ptr [183C33DACh]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B4C50h
	xor edx,edx
	mov dword ptr [rbx+88h],0
	mov rcx,rbx
	call 00000001806AC2A0h
	mov [rbx+38h],eax
	add rsp,20h
	pop rbx
	ret
	cmp dword ptr [rcx+0A0h],0
	jne short 00000001806BE1A0h
	mov edx,[rcx+34h]
	xor r9d,r9d
	inc edx
	xor r8d,r8d
	mov ecx,4A768h
	call 0000000180665070h
	mov [rbx+38h],eax
	mov dword ptr [rbx+88h],29h
	add rsp,20h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -32
	004 Compare [rcx+136], 40
	005 Move rbx, rcx
	006 JumpIfEqual {30}
	007 Compare [rcx+136], 41
	008 JumpIfNotEqual {40}
	009 Move rcx, [rcx+320]
	010 Compare rcx, 0
	011 JumpIfEqual {44}
	012 Move r8, 0
	013 Move rdx, 0
	014 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	015 Compare rax, 0
	016 JumpIfLessOrEqual {40}
	017 Move xmm1, [0x183C33DAC]
	018 Move r8, 0
	019 Move rcx, rbx
	020 Call Plant.PlayIdleAnim, rcx, rdx
	021 Move rdx, 0
	022 Move [rbx+136], 0
	023 Move rcx, rbx
	024 Call Plant.CalcRenderOrder, rcx, rdx
	025 Move [rbx+56], rax
	026 ShiftStack 32
	027 Move rbx, stack:0x0
	028 ShiftStack 8
	029 Return 
	030 Compare [rcx+160], 0
	031 JumpIfNotEqual {40}
	032 Move rdx, [rcx+52]
	033 Move r9, 0
	034 Add rdx, rdx, 1
	035 Move r8, 0
	036 Move rcx, 0x4A768
	037 Call Board.MakeRenderOrder, rcx, rdx, r8, r9
	038 Move [rbx+56], rax
	039 Move [rbx+136], 41
	040 ShiftStack 32
	041 Move rbx, stack:0x0
	042 ShiftStack 8
	043 Return 
	044 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
