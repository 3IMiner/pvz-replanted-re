# System.Void IceZombies()

- 类：`Plant`
- 汇编行数：147

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB64Ch],0
	mov rdi,rcx
	jne short 00000001806B1EF5h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Ch],1
	mov rax,[rdi+18h]
	xor ebx,ebx
	mov edx,ebx
	test rax,rax
	je near ptr 00000001806B1FC8h
	nop word ptr [rax+rax]
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806B1FC8h
	mov rax,[rdi+18h]
	test rax,rax
	je near ptr 00000001806B1FC8h
	cmp edx,[rcx+28h]
	jge short 00000001806B1F68h
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806B1FC8h
	mov r8,[184C81528h]
	mov edx,ebx
	call 0000000182449330h
	test rax,rax
	je short 00000001806B1FC8h
	xor edx,edx
	mov rcx,rax
	call 00000001806F2FF0h
	mov rax,[rdi+18h]
	inc ebx
	mov edx,ebx
	test rax,rax
	je short 00000001806B1FC8h
	jmp short 00000001806B1F10h
	mov dword ptr [rax+260h],12Ch
	mov rdx,[rdi+18h]
	test rdx,rdx
	je short 00000001806B1FC8h
	mov rcx,[rdi+10h]
	test rcx,rcx
	je short 00000001806B1FC8h
	mov edx,[rdx+268h]
	xor r8d,r8d
	call 00000001807E1000h
	test rax,rax
	je short 00000001806B1F9Eh
	mov byte ptr [rax+92h],1
	mov rcx,[rdi+18h]
	test rcx,rcx
	je short 00000001806B1FC8h
	xor edx,edx
	call 000000018065DAD0h
	test rax,rax
	je short 00000001806B1FBDh
	xor edx,edx
	mov rcx,rax
	call 00000001806E7130h
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
	005 Compare [0x184EEB64C], 0
	006 Move rdi, rcx
	007 JumpIfNotEqual {13}
	008 LoadAddress rcx, [0x184C81450]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C81528]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 Move [0x184EEB64C], 1
	013 Move rax, [rdi+24]
	014 Move rbx, 0
	015 Move rdx, rbx
	016 Compare rax, 0
	017 JumpIfEqual {72}
	018 Nop 
	019 Move rcx, [rax+112]
	020 Compare rcx, 0
	021 JumpIfEqual {72}
	022 Move rax, [rdi+24]
	023 Compare rax, 0
	024 JumpIfEqual {72}
	025 Compare rdx, [rcx+40]
	026 JumpIfGreaterOrEqual {44}
	027 Move rcx, [rax+112]
	028 Compare rcx, 0
	029 JumpIfEqual {72}
	030 Move r8, [0x184C81528]
	031 Move rdx, rbx
	032 Call 0x182449330, rcx, rdx
	033 Compare rax, 0
	034 JumpIfEqual {72}
	035 Move rdx, 0
	036 Move rcx, rax
	037 Call Zombie.HitIceTrap, rcx, rdx
	038 Move rax, [rdi+24]
	039 Add rbx, rbx, 1
	040 Move rdx, rbx
	041 Compare rax, 0
	042 JumpIfEqual {72}
	043 Goto {19}
	044 Move [rax+608], 300
	045 Move rdx, [rdi+24]
	046 Compare rdx, 0
	047 JumpIfEqual {72}
	048 Move rcx, [rdi+16]
	049 Compare rcx, 0
	050 JumpIfEqual {72}
	051 Move rdx, [rdx+616]
	052 Move r8, 0
	053 Call GameplayActivity.ParticleTryToGet, rcx, rdx
	054 Compare rax, 0
	055 JumpIfEqual {57}
	056 Move [rax+146], 1
	057 Move rcx, [rdi+24]
	058 Compare rcx, 0
	059 JumpIfEqual {72}
	060 Move rdx, 0
	061 Call Board.GetBossZombie, rcx, rdx
	062 Compare rax, 0
	063 JumpIfEqual {67}
	064 Move rdx, 0
	065 Move rcx, rax
	066 Call Zombie.BossDestroyFireball, rcx, rdx
	067 Move rbx, stack:0x30
	068 ShiftStack 32
	069 Move rdi, stack:0x0
	070 ShiftStack 8
	071 Return 
	072 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
