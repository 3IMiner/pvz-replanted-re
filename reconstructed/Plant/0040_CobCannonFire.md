# System.Void CobCannonFire(System.Int32 theTargetX, System.Int32 theTargetY)

- 类：`Plant`
- 汇编行数：139

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rbp
	mov [rsp+18h],rsi
	push rdi
	sub rsp,40h
	cmp byte ptr [184EEB66Fh],0
	mov esi,r8d
	mov ebp,edx
	mov rbx,rcx
	jne short 00000001806AC4A8h
	lea rcx,[184C984C0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB66Fh],1
	cmp byte ptr [184EEB658h],0
	mov dword ptr [rbx+88h],26h
	mov dword ptr [rbx+0DCh],0F0h
	mov rdi,[184C984C0h]
	jne short 00000001806AC4EBh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806AC5B1h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806AC5B1h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806AC5B1h
	movss xmm3,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov qword ptr [rsp+28h],0
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rcx,[rbx+140h]
	lea eax,[rbp-2Fh]
	mov [rbx+0CCh],eax
	mov [rbx+0D0h],esi
	movdqa xmm0,[183C33C90h]
	test rcx,rcx
	je short 00000001806AC5B1h
	xor r9d,r9d
	movdqa [rsp+30h],xmm0
	xor r8d,r8d
	lea rdx,[rsp+30h]
	call 000000018060F880h
	mov rbx,[rsp+50h]
	mov rbp,[rsp+58h]
	mov rsi,[rsp+60h]
	add rsp,40h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rbp
	003 Move stack:0x18, rsi
	004 ShiftStack -8
	005 Move stack:0x0, rdi
	006 ShiftStack -64
	007 Compare [0x184EEB66F], 0
	008 Move rsi, r8
	009 Move rbp, rdx
	010 Move rbx, rcx
	011 JumpIfNotEqual {15}
	012 LoadAddress rcx, [0x184C984C0]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 Move [0x184EEB66F], 1
	015 Compare [0x184EEB658], 0
	016 Move [rbx+136], 38
	017 Move [rbx+220], 240
	018 Move rdi, "anim_shooting"
	019 JumpIfNotEqual {25}
	020 LoadAddress rcx, [0x184C92A80]
	021 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	022 LoadAddress rcx, [0x184C911F8]
	023 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	024 Move [0x184EEB658], 1
	025 Compare rdi, 0
	026 JumpIfEqual {68}
	027 Move r8, ""
	028 Move r9, 0
	029 Move rdx, "anim_"
	030 Move rcx, rdi
	031 Call String.Replace, rcx, rdx, r8
	032 Move rcx, [rbx+320]
	033 Move rdi, rax
	034 Compare rcx, 0
	035 JumpIfEqual {68}
	036 Move xmm1, [0x183C33DBC]
	037 Move r9, 0
	038 Move r8, 0
	039 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	040 Move rcx, [rbx+320]
	041 Compare rcx, 0
	042 JumpIfEqual {68}
	043 Move xmm3, [0x183C33DB4]
	044 Move r8, 0
	045 Move stack:0x28, 0
	046 Move rdx, rdi
	047 Move stack:0x20, 3
	048 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	049 Move rcx, [rbx+320]
	050 LoadAddress rax, [rbp-47]
	051 Move [rbx+204], rax
	052 Move [rbx+208], rsi
	053 Move xmm0, [0x183C33C90]
	054 Compare rcx, 0
	055 JumpIfEqual {68}
	056 Move r9, 0
	057 Move stack:0x30, xmm0
	058 Move r8, 0
	059 LoadAddress rdx, stack:0x30
	060 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	061 Move rbx, stack:0x50
	062 Move rbp, stack:0x58
	063 Move rsi, stack:0x60
	064 ShiftStack 64
	065 Move rdi, stack:0x0
	066 ShiftStack 8
	067 Return 
	068 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
