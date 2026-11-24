# System.Void DoSquashDamage()

- 类：`Plant`
- 汇编行数：249

## 反汇编

```asm

Disassembly:
	mov [rsp+20h],rbp
	push rsi
	sub rsp,50h
	cmp byte ptr [184EEB64Ah],0
	mov rsi,rcx
	jne short 00000001806AE24Dh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	lea rcx,[184C7ECA0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Ah],1
	mov [rsp+60h],rbx
	xorps xmm0,xmm0
	xorps xmm1,xmm1
	mov [rsp+68h],rdi
	xor r8d,r8d
	mov [rsp+70h],r14
	xor edx,edx
	mov rcx,rsi
	movups [rsp+30h],xmm0
	movups [rsp+20h],xmm1
	call 00000001806B12F0h
	xor r9d,r9d
	lea rcx,[rsp+40h]
	xor r8d,r8d
	mov rdx,rsi
	mov ebp,eax
	call 00000001806B1660h
	mov r8,[rsi+10h]
	movups xmm0,[rax]
	movups [rsp+30h],xmm0
	test r8,r8
	je near ptr 00000001806AE3E1h
	mov r8,[r8+78h]
	test r8,r8
	je near ptr 00000001806AE3E1h
	mov rdx,[184C7ECA0h]
	mov ecx,17h
	mov r9d,1
	call 0000000180002040h
	mov rax,[rsi+18h]
	xor r14d,r14d
	mov edi,r14d
	mov edx,r14d
	test rax,rax
	je near ptr 00000001806AE3E1h
	nop dword ptr [rax]
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AE3E1h
	cmp edx,[rcx+28h]
	jge near ptr 00000001806AE3C7h
	mov rax,[rsi+18h]
	test rax,rax
	je near ptr 00000001806AE3E1h
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AE3E1h
	mov r8,[184C81528h]
	mov edx,edi
	call 0000000182449330h
	mov rbx,rax
	test rax,rax
	je near ptr 00000001806AE3E1h
	mov edx,[rax+34h]
	mov ecx,r14d
	sub edx,[rsi+34h]
	cmp dword ptr [rax+70h],19h
	cmovne ecx,edx
	test ecx,ecx
	jne short 00000001806AE3B5h
	xor r8d,r8d
	mov edx,ebp
	mov rcx,rax
	call 00000001806F12F0h
	test al,al
	je short 00000001806AE3B5h
	xor r8d,r8d
	lea rcx,[rsp+40h]
	mov rdx,rbx
	call 00000001806F2D70h
	mov rcx,[184C2AFC0h]
	movups xmm0,[rax]
	movups [rsp+20h],xmm0
	cmp [rcx+0E4h],r14d
	jne short 00000001806AE37Ch
	call 00000001804FEEB0h
	xor r8d,r8d
	lea rdx,[rsp+20h]
	lea rcx,[rsp+30h]
	call 00000001806CBAA0h
	cmp dword ptr [rbx+70h],7
	mov ecx,0FFFFFFECh
	cmovne ecx,r14d
	cmp eax,ecx
	jle short 00000001806AE3B5h
	xor r9d,r9d
	mov edx,708h
	mov r8d,12h
	mov rcx,rbx
	call 00000001806F8F60h
	mov rax,[rsi+18h]
	inc edi
	mov edx,edi
	test rax,rax
	je short 00000001806AE3E1h
	jmp near ptr 00000001806AE2E0h
	mov r14,[rsp+70h]
	mov rdi,[rsp+68h]
	mov rbx,[rsp+60h]
	mov rbp,[rsp+78h]
	add rsp,50h
	pop rsi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x20, rbp
	002 ShiftStack -8
	003 Move stack:0x0, rsi
	004 ShiftStack -80
	005 Compare [0x184EEB64A], 0
	006 Move rsi, rcx
	007 JumpIfNotEqual {17}
	008 LoadAddress rcx, [0x184C2AFC0]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C81450]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184C81528]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 LoadAddress rcx, [0x184C7ECA0]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 Move [0x184EEB64A], 1
	017 Move stack:0x60, rbx
	018 Move xmm0, 0
	019 Move xmm1, 0
	020 Move stack:0x68, rdi
	021 Move r8, 0
	022 Move stack:0x70, r14
	023 Move rdx, 0
	024 Move rcx, rsi
	025 Move stack:0x30, xmm0
	026 Move stack:0x20, xmm1
	027 Call Plant.GetDamageRangeFlags, rcx, rdx
	028 Move r9, 0
	029 LoadAddress rcx, stack:0x40
	030 Move r8, 0
	031 Move rdx, rsi
	032 Move rbp, rax
	033 Call Plant.GetPlantAttackRect, rcx, rdx
	034 Move r8, [rsi+16]
	035 Move xmm0, [rax]
	036 Move stack:0x30, xmm0
	037 Compare r8, 0
	038 JumpIfEqual {125}
	039 Move r8, [r8+120]
	040 Compare r8, 0
	041 JumpIfEqual {125}
	042 Move rdx, typeof(Reloaded.Input.IInputService)
	043 Move rcx, 23
	044 Move r9, 1
	045 Call 0x180002040, rcx, rdx, r8, r9
	046 Move rax, [rsi+24]
	047 Move r14, 0
	048 Move rdi, r14
	049 Move rdx, r14
	050 Compare rax, 0
	051 JumpIfEqual {125}
	052 Nop 
	053 Move rcx, [rax+112]
	054 Compare rcx, 0
	055 JumpIfEqual {125}
	056 Compare rdx, [rcx+40]
	057 JumpIfGreaterOrEqual {117}
	058 Move rax, [rsi+24]
	059 Compare rax, 0
	060 JumpIfEqual {125}
	061 Move rcx, [rax+112]
	062 Compare rcx, 0
	063 JumpIfEqual {125}
	064 Move r8, [0x184C81528]
	065 Move rdx, rdi
	066 Call 0x182449330, rcx, rdx
	067 Move rbx, rax
	068 Compare rax, 0
	069 JumpIfEqual {125}
	070 Move rdx, [rax+52]
	071 Move rcx, r14
	072 Subtract rdx, rdx, [rsi+52]
	073 Compare [rax+112], 25
	074 JumpIfEqual {76}
	075 Move rcx, rdx
	076 Nop 
	077 Compare rcx, 0
	078 JumpIfNotEqual {111}
	079 Move r8, 0
	080 Move rdx, rbp
	081 Move rcx, rax
	082 Call Zombie.EffectedByDamage, rcx, rdx
	083 Compare rax, 0
	084 JumpIfEqual {111}
	085 Move r8, 0
	086 LoadAddress rcx, stack:0x40
	087 Move rdx, rbx
	088 Call Zombie.GetZombieRect, rcx, rdx
	089 Move rcx, typeof(Reloaded.Gameplay.Common)
	090 Move xmm0, [rax]
	091 Move stack:0x20, xmm0
	092 Compare [rcx+228], r14
	093 JumpIfNotEqual {95}
	094 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	095 Move r8, 0
	096 LoadAddress rdx, stack:0x20
	097 LoadAddress rcx, stack:0x30
	098 Call Common.GetRectOverlap, rcx, rdx, r8
	099 Compare [rbx+112], 7
	100 Move rcx, 0xFFFFFFEC
	101 JumpIfEqual {103}
	102 Move rcx, r14
	103 Nop 
	104 Compare rax, rcx
	105 JumpIfLessOrEqual {111}
	106 Move r9, 0
	107 Move rdx, 1800
	108 Move r8, 18
	109 Move rcx, rbx
	110 Call Zombie.TakeDamage, rcx, rdx, r8
	111 Move rax, [rsi+24]
	112 Add rdi, rdi, 1
	113 Move rdx, rdi
	114 Compare rax, 0
	115 JumpIfEqual {125}
	116 Goto {53}
	117 Move r14, stack:0x70
	118 Move rdi, stack:0x68
	119 Move rbx, stack:0x60
	120 Move rbp, stack:0x78
	121 ShiftStack 80
	122 Move rsi, stack:0x0
	123 ShiftStack 8
	124 Return 
	125 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
