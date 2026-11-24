# System.Int32 DistanceToClosestZombie()

- 类：`Plant`
- 汇编行数：223

## 反汇编

```asm

Disassembly:
	mov [rsp+10h],rbx
	mov [rsp+18h],rbp
	push rsi
	push r14
	push r15
	sub rsp,50h
	cmp byte ptr [184EEB663h],0
	mov rbp,rcx
	jne short 00000001806AD10Ah
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	mov byte ptr [184EEB663h],1
	xorps xmm0,xmm0
	mov [rsp+70h],rdi
	xorps xmm1,xmm1
	xor r8d,r8d
	xor edx,edx
	mov rcx,rbp
	movups [rsp+30h],xmm0
	movups [rsp+20h],xmm1
	call 00000001806B12F0h
	xor r9d,r9d
	lea rcx,[rsp+40h]
	xor r8d,r8d
	mov rdx,rbp
	mov r14d,eax
	call 00000001806B1660h
	mov rcx,[rbp+18h]
	xor r15d,r15d
	mov ebx,3E8h
	mov esi,r15d
	mov edx,r15d
	movups xmm0,[rax]
	movups [rsp+30h],xmm0
	test rcx,rcx
	je near ptr 00000001806AD255h
	nop word ptr [rax+rax]
	mov rax,[rcx+70h]
	test rax,rax
	je near ptr 00000001806AD255h
	cmp edx,[rax+28h]
	jge near ptr 00000001806AD237h
	mov rax,[rbp+18h]
	test rax,rax
	je near ptr 00000001806AD255h
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AD255h
	mov r8,[184C81528h]
	mov edx,esi
	call 0000000182449330h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806AD255h
	mov ecx,[rbp+34h]
	cmp [rax+34h],ecx
	jne short 00000001806AD225h
	xor r8d,r8d
	mov edx,r14d
	mov rcx,rax
	call 00000001806F12F0h
	test al,al
	je short 00000001806AD225h
	xor r8d,r8d
	lea rcx,[rsp+40h]
	mov rdx,rdi
	call 00000001806F2D70h
	mov rcx,[184C2AFC0h]
	movups xmm0,[rax]
	movups [rsp+20h],xmm0
	cmp [rcx+0E4h],r15d
	jne short 00000001806AD201h
	call 00000001804FEEB0h
	xor r8d,r8d
	lea rdx,[rsp+20h]
	lea rcx,[rsp+30h]
	call 00000001806CBAA0h
	mov ecx,eax
	neg ecx
	cmp ebx,ecx
	jle short 00000001806AD225h
	mov ebx,eax
	neg ebx
	test ebx,ebx
	cmovle ebx,r15d
	mov rcx,[rbp+18h]
	inc esi
	mov edx,esi
	test rcx,rcx
	je short 00000001806AD255h
	jmp near ptr 00000001806AD170h
	mov rdi,[rsp+70h]
	mov eax,ebx
	mov rbx,[rsp+78h]
	mov rbp,[rsp+80h]
	add rsp,50h
	pop r15
	pop r14
	pop rsi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x10, rbx
	002 Move stack:0x18, rbp
	003 ShiftStack -8
	004 Move stack:0x0, rsi
	005 ShiftStack -8
	006 Move stack:0x0, r14
	007 ShiftStack -8
	008 Move stack:0x0, r15
	009 ShiftStack -80
	010 Compare [0x184EEB663], 0
	011 Move rbp, rcx
	012 JumpIfNotEqual {20}
	013 LoadAddress rcx, [0x184C2AFC0]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C81450]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C81528]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 Move [0x184EEB663], 1
	020 Move xmm0, 0
	021 Move stack:0x70, rdi
	022 Move xmm1, 0
	023 Move r8, 0
	024 Move rdx, 0
	025 Move rcx, rbp
	026 Move stack:0x30, xmm0
	027 Move stack:0x20, xmm1
	028 Call Plant.GetDamageRangeFlags, rcx, rdx
	029 Move r9, 0
	030 LoadAddress rcx, stack:0x40
	031 Move r8, 0
	032 Move rdx, rbp
	033 Move r14, rax
	034 Call Plant.GetPlantAttackRect, rcx, rdx
	035 Move rcx, [rbp+24]
	036 Move r15, 0
	037 Move rbx, 1000
	038 Move rsi, r15
	039 Move rdx, r15
	040 Move xmm0, [rax]
	041 Move stack:0x30, xmm0
	042 Compare rcx, 0
	043 JumpIfEqual {113}
	044 Nop 
	045 Move rax, [rcx+112]
	046 Compare rax, 0
	047 JumpIfEqual {113}
	048 Compare rdx, [rax+40]
	049 JumpIfGreaterOrEqual {101}
	050 Move rax, [rbp+24]
	051 Compare rax, 0
	052 JumpIfEqual {113}
	053 Move rcx, [rax+112]
	054 Compare rcx, 0
	055 JumpIfEqual {113}
	056 Move r8, [0x184C81528]
	057 Move rdx, rsi
	058 Call 0x182449330, rcx, rdx
	059 Move rdi, rax
	060 Compare rax, 0
	061 JumpIfEqual {113}
	062 Move rcx, [rbp+52]
	063 Compare [rax+52], rcx
	064 JumpIfNotEqual {95}
	065 Move r8, 0
	066 Move rdx, r14
	067 Move rcx, rax
	068 Call Zombie.EffectedByDamage, rcx, rdx
	069 Compare rax, 0
	070 JumpIfEqual {95}
	071 Move r8, 0
	072 LoadAddress rcx, stack:0x40
	073 Move rdx, rdi
	074 Call Zombie.GetZombieRect, rcx, rdx
	075 Move rcx, typeof(Reloaded.Gameplay.Common)
	076 Move xmm0, [rax]
	077 Move stack:0x20, xmm0
	078 Compare [rcx+228], r15
	079 JumpIfNotEqual {81}
	080 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	081 Move r8, 0
	082 LoadAddress rdx, stack:0x20
	083 LoadAddress rcx, stack:0x30
	084 Call Common.GetRectOverlap, rcx, rdx, r8
	085 Move rcx, rax
	086 Neg rcx
	087 Compare rbx, rcx
	088 JumpIfLessOrEqual {95}
	089 Move rbx, rax
	090 Neg rbx
	091 Compare rbx, 0
	092 JumpIfGreater {94}
	093 Move rbx, r15
	094 Nop 
	095 Move rcx, [rbp+24]
	096 Add rsi, rsi, 1
	097 Move rdx, rsi
	098 Compare rcx, 0
	099 JumpIfEqual {113}
	100 Goto {45}
	101 Move rdi, stack:0x70
	102 Move rax, rbx
	103 Move rbx, stack:0x78
	104 Move rbp, stack:0x80
	105 ShiftStack 80
	106 Move r15, stack:0x0
	107 ShiftStack 8
	108 Move r14, stack:0x0
	109 ShiftStack 8
	110 Move rsi, stack:0x0
	111 ShiftStack 8
	112 Return rax
	113 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
