# System.Void SpikeweedAttack()

- 类：`Plant`
- 汇编行数：131

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB674h],0
	mov rbx,rcx
	jne short 00000001806B5BC1h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C93068h]
	call 00000001804FEB70h
	mov byte ptr [184EEB674h],1
	cmp dword ptr [rbx+88h],12h
	je near ptr 00000001806B5CBCh
	cmp byte ptr [184EEB658h],0
	mov [rsp+40h],rdi
	mov rdi,[184C93068h]
	jne short 00000001806B5C02h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B5CC2h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806B5CC2h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B5CC2h
	movss xmm3,dword ptr [183C33EE4h]
	xor r8d,r8d
	mov qword ptr [rsp+28h],0
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov r8,[rbx+10h]
	test r8,r8
	je short 00000001806B5CC2h
	mov r8,[r8+58h]
	test r8,r8
	je short 00000001806B5CC2h
	mov rdx,[184C75168h]
	mov ecx,19h
	mov r9d,96h
	call 0000000180002040h
	mov rdi,[rsp+40h]
	mov dword ptr [rbx+88h],12h
	mov dword ptr [rbx+0A0h],64h
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB674], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {12}
	007 LoadAddress rcx, [0x184C75168]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C93068]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 Move [0x184EEB674], 1
	012 Compare [rbx+136], 18
	013 JumpIfEqual {60}
	014 Compare [0x184EEB658], 0
	015 Move stack:0x40, rdi
	016 Move rdi, "anim_attack"
	017 JumpIfNotEqual {23}
	018 LoadAddress rcx, [0x184C92A80]
	019 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	020 LoadAddress rcx, [0x184C911F8]
	021 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	022 Move [0x184EEB658], 1
	023 Compare rdi, 0
	024 JumpIfEqual {64}
	025 Move r8, ""
	026 Move r9, 0
	027 Move rdx, "anim_"
	028 Move rcx, rdi
	029 Call String.Replace, rcx, rdx, r8
	030 Move rcx, [rbx+320]
	031 Move rdi, rax
	032 Compare rcx, 0
	033 JumpIfEqual {64}
	034 Move xmm1, [0x183C33DBC]
	035 Move r9, 0
	036 Move r8, 0
	037 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	038 Move rcx, [rbx+320]
	039 Compare rcx, 0
	040 JumpIfEqual {64}
	041 Move xmm3, [0x183C33EE4]
	042 Move r8, 0
	043 Move stack:0x28, 0
	044 Move rdx, rdi
	045 Move stack:0x20, 3
	046 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	047 Move r8, [rbx+16]
	048 Compare r8, 0
	049 JumpIfEqual {64}
	050 Move r8, [r8+88]
	051 Compare r8, 0
	052 JumpIfEqual {64}
	053 Move rdx, typeof(Reloaded.Services.IAudioService)
	054 Move rcx, 25
	055 Move r9, 150
	056 Call 0x180002040, rcx, rdx, r8, r9
	057 Move rdi, stack:0x40
	058 Move [rbx+136], 18
	059 Move [rbx+160], 100
	060 ShiftStack 48
	061 Move rbx, stack:0x0
	062 ShiftStack 8
	063 Return 
	064 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
