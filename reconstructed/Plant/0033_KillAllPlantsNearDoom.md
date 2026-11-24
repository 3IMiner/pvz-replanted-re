# System.Void KillAllPlantsNearDoom()

- 类：`Plant`
- 汇编行数：111

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB651h],0
	mov rbx,rcx
	jne short 00000001806B2575h
	lea rcx,[184C7F5F0h]
	call 00000001804FEB70h
	lea rcx,[184C7F6C8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB651h],1
	mov rax,[rbx+18h]
	xor edi,edi
	mov edx,edi
	test rax,rax
	je short 00000001806B25E9h
	mov rcx,[rax+78h]
	test rcx,rcx
	je short 00000001806B25E9h
	cmp edx,[rcx+28h]
	jge short 00000001806B25DEh
	mov rax,[rbx+18h]
	test rax,rax
	je short 00000001806B25E9h
	mov rcx,[rax+78h]
	test rcx,rcx
	je short 00000001806B25E9h
	mov r8,[184C7F6C8h]
	mov edx,edi
	call 0000000182449330h
	test rax,rax
	je short 00000001806B25E9h
	mov ecx,[rbx+34h]
	cmp [rax+34h],ecx
	jne short 00000001806B25CFh
	mov ecx,[rax+74h]
	cmp ecx,[rbx+74h]
	jne short 00000001806B25CFh
	xor edx,edx
	mov rcx,rax
	call 00000001806ACD40h
	mov rax,[rbx+18h]
	inc edi
	mov edx,edi
	test rax,rax
	je short 00000001806B25E9h
	jmp short 00000001806B2582h
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -32
	005 Compare [0x184EEB651], 0
	006 Move rbx, rcx
	007 JumpIfNotEqual {13}
	008 LoadAddress rcx, [0x184C7F5F0]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C7F6C8]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 Move [0x184EEB651], 1
	013 Move rax, [rbx+24]
	014 Move rdi, 0
	015 Move rdx, rdi
	016 Compare rax, 0
	017 JumpIfEqual {54}
	018 Move rcx, [rax+120]
	019 Compare rcx, 0
	020 JumpIfEqual {54}
	021 Compare rdx, [rcx+40]
	022 JumpIfGreaterOrEqual {49}
	023 Move rax, [rbx+24]
	024 Compare rax, 0
	025 JumpIfEqual {54}
	026 Move rcx, [rax+120]
	027 Compare rcx, 0
	028 JumpIfEqual {54}
	029 Move r8, [0x184C7F6C8]
	030 Move rdx, rdi
	031 Call 0x182449330, rcx, rdx
	032 Compare rax, 0
	033 JumpIfEqual {54}
	034 Move rcx, [rbx+52]
	035 Compare [rax+52], rcx
	036 JumpIfNotEqual {43}
	037 Move rcx, [rax+116]
	038 Compare rcx, [rbx+116]
	039 JumpIfNotEqual {43}
	040 Move rdx, 0
	041 Move rcx, rax
	042 Call Plant.Die, rcx, rdx
	043 Move rax, [rbx+24]
	044 Add rdi, rdi, 1
	045 Move rdx, rdi
	046 Compare rax, 0
	047 JumpIfEqual {54}
	048 Goto {18}
	049 Move rbx, stack:0x30
	050 ShiftStack 32
	051 Move rdi, stack:0x0
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
