# System.Void BlowAwayFliers(System.Int32 theX, System.Int32 theRow)

- 类：`Plant`
- 汇编行数：167

## 反汇编

```asm

Disassembly:
	mov [rsp+10h],rsi
	push rdi
	sub rsp,30h
	cmp byte ptr [184EEB64Dh],0
	mov rsi,rcx
	jne short 00000001806ABFB1h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Dh],1
	mov rax,[rsi+18h]
	xor edi,edi
	mov [rsp+40h],rbx
	mov edx,edi
	test rax,rax
	je near ptr 00000001806AC0ADh
	nop word ptr [rax+rax]
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AC0ADh
	cmp edx,[rcx+28h]
	jge short 00000001806AC061h
	mov rax,[rsi+18h]
	test rax,rax
	je near ptr 00000001806AC0ADh
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AC0ADh
	mov r8,[184C81528h]
	mov edx,edi
	call 0000000182449330h
	mov rbx,rax
	test rax,rax
	je near ptr 00000001806AC0ADh
	xor edx,edx
	mov rcx,rax
	call 00000001806F3600h
	test al,al
	jne short 00000001806AC04Fh
	xor r8d,r8d
	lea rcx,[rsp+20h]
	mov rdx,rbx
	call 00000001806F2D70h
	xor edx,edx
	mov rcx,rbx
	call 00000001806F3650h
	test al,al
	je short 00000001806AC04Fh
	cmp dword ptr [rbx+74h],4Ah
	je short 00000001806AC04Fh
	mov byte ptr [rbx+111h],1
	mov rax,[rsi+18h]
	inc edi
	mov edx,edi
	test rax,rax
	je short 00000001806AC0ADh
	jmp near ptr 00000001806ABFD0h
	mov rax,[rsi+10h]
	test rax,rax
	je short 00000001806AC0ADh
	mov r8,[rax+58h]
	test r8,r8
	je short 00000001806AC0ADh
	mov rdx,[184C75168h]
	mov ecx,19h
	mov r9d,7
	call 0000000180002040h
	mov rax,[rsi+18h]
	test rax,rax
	je short 00000001806AC0ADh
	mov rbx,[rsp+40h]
	mov rsi,[rsp+48h]
	mov dword ptr [rax+150h],0FA0h
	add rsp,30h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x10, rsi
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -48
	005 Compare [0x184EEB64D], 0
	006 Move rsi, rcx
	007 JumpIfNotEqual {15}
	008 LoadAddress rcx, [0x184C81450]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C81528]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184C75168]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 Move [0x184EEB64D], 1
	015 Move rax, [rsi+24]
	016 Move rdi, 0
	017 Move stack:0x40, rbx
	018 Move rdx, rdi
	019 Compare rax, 0
	020 JumpIfEqual {82}
	021 Nop 
	022 Move rcx, [rax+112]
	023 Compare rcx, 0
	024 JumpIfEqual {82}
	025 Compare rdx, [rcx+40]
	026 JumpIfGreaterOrEqual {62}
	027 Move rax, [rsi+24]
	028 Compare rax, 0
	029 JumpIfEqual {82}
	030 Move rcx, [rax+112]
	031 Compare rcx, 0
	032 JumpIfEqual {82}
	033 Move r8, [0x184C81528]
	034 Move rdx, rdi
	035 Call 0x182449330, rcx, rdx
	036 Move rbx, rax
	037 Compare rax, 0
	038 JumpIfEqual {82}
	039 Move rdx, 0
	040 Move rcx, rax
	041 Call Zombie.IsDeadOrDying, rcx, rdx
	042 Compare rax, 0
	043 JumpIfNotEqual {56}
	044 Move r8, 0
	045 LoadAddress rcx, stack:0x20
	046 Move rdx, rbx
	047 Call Zombie.GetZombieRect, rcx, rdx
	048 Move rdx, 0
	049 Move rcx, rbx
	050 Call Zombie.IsFlying, rcx, rdx
	051 Compare rax, 0
	052 JumpIfEqual {56}
	053 Compare [rbx+116], 74
	054 JumpIfEqual {56}
	055 Move [rbx+273], 1
	056 Move rax, [rsi+24]
	057 Add rdi, rdi, 1
	058 Move rdx, rdi
	059 Compare rax, 0
	060 JumpIfEqual {82}
	061 Goto {22}
	062 Move rax, [rsi+16]
	063 Compare rax, 0
	064 JumpIfEqual {82}
	065 Move r8, [rax+88]
	066 Compare r8, 0
	067 JumpIfEqual {82}
	068 Move rdx, typeof(Reloaded.Services.IAudioService)
	069 Move rcx, 25
	070 Move r9, 7
	071 Call 0x180002040, rcx, rdx, r8, r9
	072 Move rax, [rsi+24]
	073 Compare rax, 0
	074 JumpIfEqual {82}
	075 Move rbx, stack:0x40
	076 Move rsi, stack:0x48
	077 Move [rax+336], 4000
	078 ShiftStack 48
	079 Move rdi, stack:0x0
	080 ShiftStack 8
	081 Return 
	082 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
