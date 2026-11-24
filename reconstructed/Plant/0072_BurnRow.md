# System.Void BurnRow(System.Int32 theRow)

- 类：`Plant`
- 汇编行数：271

## 反汇编

```asm

Disassembly:
	mov [rsp+10h],rbp
	mov [rsp+18h],rsi
	push rdi
	push r14
	push r15
	sub rsp,20h
	cmp byte ptr [184EEB64Bh],0
	mov r14d,edx
	mov rsi,rcx
	jne short 00000001806AC119h
	lea rcx,[184C7E798h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	lea rcx,[184C7E870h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Bh],1
	xor r8d,r8d
	mov [rsp+40h],rbx
	xor edx,edx
	mov rcx,rsi
	call 00000001806B12F0h
	mov rcx,[rsi+18h]
	xor edi,edi
	mov r15d,eax
	mov ebp,edi
	mov r8d,edi
	test rcx,rcx
	je near ptr 00000001806AC297h
	mov rdx,[rcx+70h]
	test rdx,rdx
	je near ptr 00000001806AC297h
	mov rax,[rsi+18h]
	cmp r8d,[rdx+28h]
	jge near ptr 00000001806AC1EAh
	test rax,rax
	je near ptr 00000001806AC297h
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AC297h
	mov r8,[184C81528h]
	mov edx,ebp
	call 0000000182449330h
	mov rbx,rax
	test rax,rax
	je near ptr 00000001806AC297h
	mov eax,[rax+70h]
	cmp eax,22h
	je short 00000001806AC1D3h
	cmp eax,24h
	je short 00000001806AC1D3h
	mov ecx,[rbx+34h]
	mov eax,edi
	sub ecx,[rsi+34h]
	cmp dword ptr [rbx+70h],19h
	cmovne eax,ecx
	test eax,eax
	jne short 00000001806AC1D3h
	xor r8d,r8d
	mov edx,r15d
	mov rcx,rbx
	call 00000001806F12F0h
	test al,al
	je short 00000001806AC1D3h
	xor edx,edx
	mov rcx,rbx
	call 00000001806F5C60h
	xor edx,edx
	mov rcx,rbx
	call 00000001806E5750h
	mov rcx,[rsi+18h]
	inc ebp
	mov r8d,ebp
	test rcx,rcx
	je near ptr 00000001806AC297h
	jmp near ptr 00000001806AC142h
	mov edx,edi
	test rax,rax
	je near ptr 00000001806AC297h
	nop word ptr [rax+rax]
	mov rcx,[rax+98h]
	test rcx,rcx
	je near ptr 00000001806AC297h
	mov eax,[rcx+28h]
	mov rcx,[rsi+18h]
	test rcx,rcx
	je short 00000001806AC297h
	cmp edx,eax
	jge short 00000001806AC264h
	mov rcx,[rcx+98h]
	test rcx,rcx
	je short 00000001806AC297h
	mov r8,[184C7E870h]
	mov edx,edi
	call 0000000182449330h
	test rax,rax
	je short 00000001806AC297h
	cmp [rax+7Ch],r14d
	jne short 00000001806AC255h
	cmp dword ptr [rax+70h],3
	jne short 00000001806AC255h
	xor edx,edx
	mov rcx,rax
	call 00000001806C2390h
	mov rax,[rsi+18h]
	inc edi
	mov edx,edi
	test rax,rax
	jne short 00000001806AC200h
	jmp short 00000001806AC297h
	xor edx,edx
	call 000000018065DAD0h
	test rax,rax
	je short 00000001806AC27Eh
	xor r8d,r8d
	mov edx,r14d
	mov rcx,rax
	call 00000001806E7270h
	mov rbx,[rsp+40h]
	mov rbp,[rsp+48h]
	mov rsi,[rsp+50h]
	add rsp,20h
	pop r15
	pop r14
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x10, rbp
	002 Move stack:0x18, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -8
	006 Move stack:0x0, r14
	007 ShiftStack -8
	008 Move stack:0x0, r15
	009 ShiftStack -32
	010 Compare [0x184EEB64B], 0
	011 Move r14, rdx
	012 Move rsi, rcx
	013 JumpIfNotEqual {23}
	014 LoadAddress rcx, [0x184C7E798]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 LoadAddress rcx, [0x184C81450]
	017 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	018 LoadAddress rcx, [0x184C81528]
	019 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	020 LoadAddress rcx, [0x184C7E870]
	021 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	022 Move [0x184EEB64B], 1
	023 Move r8, 0
	024 Move stack:0x40, rbx
	025 Move rdx, 0
	026 Move rcx, rsi
	027 Call Plant.GetDamageRangeFlags, rcx, rdx
	028 Move rcx, [rsi+24]
	029 Move rdi, 0
	030 Move r15, rax
	031 Move rbp, rdi
	032 Move r8, rdi
	033 Compare rcx, 0
	034 JumpIfEqual {137}
	035 Move rdx, [rcx+112]
	036 Compare rdx, 0
	037 JumpIfEqual {137}
	038 Move rax, [rsi+24]
	039 Compare r8, [rdx+40]
	040 JumpIfGreaterOrEqual {84}
	041 Compare rax, 0
	042 JumpIfEqual {137}
	043 Move rcx, [rax+112]
	044 Compare rcx, 0
	045 JumpIfEqual {137}
	046 Move r8, [0x184C81528]
	047 Move rdx, rbp
	048 Call 0x182449330, rcx, rdx
	049 Move rbx, rax
	050 Compare rax, 0
	051 JumpIfEqual {137}
	052 Move rax, [rax+112]
	053 Compare rax, 34
	054 JumpIfEqual {78}
	055 Compare rax, 36
	056 JumpIfEqual {78}
	057 Move rcx, [rbx+52]
	058 Move rax, rdi
	059 Subtract rcx, rcx, [rsi+52]
	060 Compare [rbx+112], 25
	061 JumpIfEqual {63}
	062 Move rax, rcx
	063 Nop 
	064 Compare rax, 0
	065 JumpIfNotEqual {78}
	066 Move r8, 0
	067 Move rdx, r15
	068 Move rcx, rbx
	069 Call Zombie.EffectedByDamage, rcx, rdx
	070 Compare rax, 0
	071 JumpIfEqual {78}
	072 Move rdx, 0
	073 Move rcx, rbx
	074 Call Zombie.RemoveColdEffects, rcx, rdx
	075 Move rdx, 0
	076 Move rcx, rbx
	077 Call Zombie.ApplyBurn, rcx, rdx
	078 Move rcx, [rsi+24]
	079 Add rbp, rbp, 1
	080 Move r8, rbp
	081 Compare rcx, 0
	082 JumpIfEqual {137}
	083 Goto {35}
	084 Move rdx, rdi
	085 Compare rax, 0
	086 JumpIfEqual {137}
	087 Nop 
	088 Move rcx, [rax+152]
	089 Compare rcx, 0
	090 JumpIfEqual {137}
	091 Move rax, [rcx+40]
	092 Move rcx, [rsi+24]
	093 Compare rcx, 0
	094 JumpIfEqual {137}
	095 Compare rdx, rax
	096 JumpIfGreaterOrEqual {118}
	097 Move rcx, [rcx+152]
	098 Compare rcx, 0
	099 JumpIfEqual {137}
	100 Move r8, [0x184C7E870]
	101 Move rdx, rdi
	102 Call 0x182449330, rcx, rdx
	103 Compare rax, 0
	104 JumpIfEqual {137}
	105 Compare [rax+124], r14
	106 JumpIfNotEqual {112}
	107 Compare [rax+112], 3
	108 JumpIfNotEqual {112}
	109 Move rdx, 0
	110 Move rcx, rax
	111 Call GridItem.GridItemDie, rcx, rdx
	112 Move rax, [rsi+24]
	113 Add rdi, rdi, 1
	114 Move rdx, rdi
	115 Compare rax, 0
	116 JumpIfNotEqual {88}
	117 Goto {137}
	118 Move rdx, 0
	119 Call Board.GetBossZombie, rcx, rdx
	120 Compare rax, 0
	121 JumpIfEqual {126}
	122 Move r8, 0
	123 Move rdx, r14
	124 Move rcx, rax
	125 Call Zombie.BossDestroyIceballInRow, rcx, rdx
	126 Move rbx, stack:0x40
	127 Move rbp, stack:0x48
	128 Move rsi, stack:0x50
	129 ShiftStack 32
	130 Move r15, stack:0x0
	131 ShiftStack 8
	132 Move r14, stack:0x0
	133 ShiftStack 8
	134 Move rdi, stack:0x0
	135 ShiftStack 8
	136 Return 
	137 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
