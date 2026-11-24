# System.Void UpdateSpikeweed()

- 类：`Plant`
- 汇编行数：145

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	cmp byte ptr [184EEB664h],0
	mov rbx,rcx
	jne short 00000001806BD215h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB664h],1
	cmp dword ptr [rbx+88h],12h
	je short 00000001806BD249h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	je short 00000001806BD243h
	xor edx,edx
	mov rcx,rbx
	add rsp,20h
	pop rbx
	jmp near ptr 00000001806B5B90h
	add rsp,20h
	pop rbx
	ret
	cmp dword ptr [rbx+0A0h],0
	je short 00000001806BD287h
	cmp dword ptr [rbx+70h],2Eh
	mov eax,[rbx+0A0h]
	je short 00000001806BD265h
	cmp eax,4Bh
	je short 00000001806BD26Fh
	jmp short 00000001806BD291h
	cmp eax,46h
	je short 00000001806BD26Fh
	cmp eax,20h
	jne short 00000001806BD291h
	xor r9d,r9d
	mov edx,14h
	mov r8d,21h
	mov rcx,rbx
	call 00000001806AD520h
	jmp short 00000001806BD291h
	mov dword ptr [rbx+88h],0
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BD2EBh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806BD243h
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BD2C0h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DB4h]
	call 00000001806CBD40h
	xor r8d,r8d
	movaps xmm1,xmm0
	mov rcx,rbx
	add rsp,20h
	pop rbx
	jmp near ptr 00000001806B4C50h
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -32
	004 Compare [0x184EEB664], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {10}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 Move [0x184EEB664], 1
	010 Compare [rbx+136], 18
	011 JumpIfEqual {30}
	012 Move rdx, [rbx+52]
	013 Move r9, 0
	014 Move r8, 0
	015 Move rcx, rbx
	016 Call Plant.FindTargetZombie, rcx, rdx, r8
	017 Compare rax, 0
	018 JumpIfEqual {26}
	019 Move rdx, 0
	020 Move rcx, rbx
	021 ShiftStack 32
	022 Move rbx, stack:0x0
	023 ShiftStack 8
	024 Call Plant.SpikeweedAttack, rcx, rdx
	025 Return 
	026 ShiftStack 32
	027 Move rbx, stack:0x0
	028 ShiftStack 8
	029 Return 
	030 Compare [rbx+160], 0
	031 JumpIfEqual {48}
	032 Compare [rbx+112], 46
	033 Move rax, [rbx+160]
	034 JumpIfEqual {38}
	035 Compare rax, 75
	036 JumpIfEqual {42}
	037 Goto {49}
	038 Compare rax, 70
	039 JumpIfEqual {42}
	040 Compare rax, 32
	041 JumpIfNotEqual {49}
	042 Move r9, 0
	043 Move rdx, 20
	044 Move r8, 33
	045 Move rcx, rbx
	046 Call Plant.DoRowAreaDamage, rcx, rdx, r8
	047 Goto {49}
	048 Move [rbx+136], 0
	049 Move rcx, [rbx+320]
	050 Compare rcx, 0
	051 JumpIfEqual {73}
	052 Move r8, 0
	053 Move rdx, 0
	054 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	055 Compare rax, 0
	056 JumpIfLessOrEqual {26}
	057 Move rcx, typeof(Reloaded.Gameplay.Common)
	058 Compare [rcx+228], 0
	059 JumpIfNotEqual {61}
	060 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	061 Move xmm1, [0x183C33DB8]
	062 Move r8, 0
	063 Move xmm0, [0x183C33DB4]
	064 Call Common.RandRangeFloat, xmm0, xmm1, r8
	065 Move r8, 0
	066 Move xmm1, xmm0
	067 Move rcx, rbx
	068 ShiftStack 32
	069 Move rbx, stack:0x0
	070 ShiftStack 8
	071 Call Plant.PlayIdleAnim, rcx, rdx
	072 Return 
	073 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
