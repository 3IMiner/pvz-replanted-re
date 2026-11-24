# System.Void LaunchStarFruit()

- 类：`Plant`
- 汇编行数：111

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB653h],0
	mov rbx,rcx
	jne short 00000001806B2615h
	lea rcx,[184C983E8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB653h],1
	xor edx,edx
	mov rcx,rbx
	call 00000001806AF750h
	test al,al
	je near ptr 00000001806B26DEh
	mov [rsp+40h],rdi
	cmp byte ptr [184EEB658h],0
	mov rdi,[184C983E8h]
	jne short 00000001806B265Bh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B26E4h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je short 00000001806B26E4h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B26E4h
	movss xmm3,dword ptr [183C33FB8h]
	xor r8d,r8d
	mov qword ptr [rsp+28h],0
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rdi,[rsp+40h]
	mov dword ptr [rbx+0DCh],28h
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB653], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {10}
	007 LoadAddress rcx, [0x184C983E8]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 Move [0x184EEB653], 1
	010 Move rdx, 0
	011 Move rcx, rbx
	012 Call Plant.FindStarFruitTarget, rcx, rdx
	013 Compare rax, 0
	014 JumpIfEqual {50}
	015 Move stack:0x40, rdi
	016 Compare [0x184EEB658], 0
	017 Move rdi, "anim_shoot"
	018 JumpIfNotEqual {24}
	019 LoadAddress rcx, [0x184C92A80]
	020 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	021 LoadAddress rcx, [0x184C911F8]
	022 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	023 Move [0x184EEB658], 1
	024 Compare rdi, 0
	025 JumpIfEqual {54}
	026 Move r8, ""
	027 Move r9, 0
	028 Move rdx, "anim_"
	029 Move rcx, rdi
	030 Call String.Replace, rcx, rdx, r8
	031 Move rcx, [rbx+320]
	032 Move rdi, rax
	033 Compare rcx, 0
	034 JumpIfEqual {54}
	035 Move xmm1, [0x183C33DBC]
	036 Move r9, 0
	037 Move r8, 0
	038 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	039 Move rcx, [rbx+320]
	040 Compare rcx, 0
	041 JumpIfEqual {54}
	042 Move xmm3, [0x183C33FB8]
	043 Move r8, 0
	044 Move stack:0x28, 0
	045 Move rdx, rdi
	046 Move stack:0x20, 3
	047 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	048 Move rdi, stack:0x40
	049 Move [rbx+220], 40
	050 ShiftStack 48
	051 Move rbx, stack:0x0
	052 ShiftStack 8
	053 Return 
	054 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
