# System.Void DoRowAreaDamage(System.Int32 theDamage, Reloaded.Gameplay.DamageFlags theDamageFlags)

- 类：`Plant`
- 汇编行数：317

## 反汇编

```asm

Disassembly:
	mov [rsp+18h],rbp
	mov [rsp+20h],rsi
	push r12
	push r14
	push r15
	sub rsp,50h
	cmp byte ptr [184EEB647h],0
	mov r14d,r8d
	mov r15d,edx
	mov rsi,rcx
	jne short 00000001806AD57Dh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	mov byte ptr [184EEB647h],1
	xorps xmm0,xmm0
	mov [rsp+70h],rbx
	xorps xmm1,xmm1
	mov [rsp+78h],rdi
	xor r8d,r8d
	xor edx,edx
	mov rcx,rsi
	movups [rsp+30h],xmm0
	movups [rsp+20h],xmm1
	call 00000001806B12F0h
	xor r9d,r9d
	lea rcx,[rsp+40h]
	xor r8d,r8d
	mov rdx,rsi
	mov r12d,eax
	call 00000001806B1660h
	mov rcx,[rsi+18h]
	xor ebp,ebp
	xor edx,edx
	movups xmm0,[rax]
	movups [rsp+30h],xmm0
	test rcx,rcx
	je near ptr 00000001806AD76Fh
	mov rax,[rcx+70h]
	test rax,rax
	je near ptr 00000001806AD76Fh
	cmp edx,[rax+28h]
	jge near ptr 00000001806AD74Eh
	mov rax,[rsi+18h]
	test rax,rax
	je near ptr 00000001806AD76Fh
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AD76Fh
	mov r8,[184C81528h]
	mov edx,ebp
	call 0000000182449330h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806AD76Fh
	mov ecx,[rax+34h]
	xor eax,eax
	sub ecx,[rsi+34h]
	cmp dword ptr [rdi+70h],19h
	cmovne eax,ecx
	cmp dword ptr [rsi+70h],2Ah
	je short 00000001806AD63Ch
	test eax,eax
	jne near ptr 00000001806AD73Ch
	jmp short 00000001806AD647h
	inc eax
	cmp eax,2
	ja near ptr 00000001806AD73Ch
	movzx ebx,byte ptr [rdi+116h]
	xor edx,edx
	mov rcx,rsi
	call 00000001806B2290h
	cmp bl,al
	jne near ptr 00000001806AD73Ch
	xor r8d,r8d
	mov edx,r12d
	mov rcx,rdi
	call 00000001806F12F0h
	test al,al
	je near ptr 00000001806AD73Ch
	xor r8d,r8d
	lea rcx,[rsp+40h]
	mov rdx,rdi
	call 00000001806F2D70h
	mov rcx,[184C2AFC0h]
	movups xmm0,[rax]
	movups [rsp+20h],xmm0
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AD6A3h
	call 00000001804FEEB0h
	xor r8d,r8d
	lea rdx,[rsp+20h]
	lea rcx,[rsp+30h]
	call 00000001806CBAA0h
	test eax,eax
	jle near ptr 00000001806AD73Ch
	cmp dword ptr [rdi+70h],0Ch
	mov ebx,r15d
	je short 00000001806AD6CCh
	cmp dword ptr [rdi+70h],16h
	jne short 00000001806AD703h
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AD6E1h
	call 00000001804FEEB0h
	test r14b,20h
	jbe short 00000001806AD703h
	mov ebx,708h
	xor edx,edx
	mov rcx,rsi
	cmp dword ptr [rsi+70h],2Eh
	je short 00000001806AD6FEh
	call 00000001806ACD40h
	jmp short 00000001806AD703h
	call 00000001806B5A90h
	xor r9d,r9d
	mov r8d,r14d
	mov edx,ebx
	mov rcx,rdi
	call 00000001806F8F60h
	mov r8,[rsi+10h]
	test r8,r8
	je short 00000001806AD76Fh
	mov r8,[r8+58h]
	test r8,r8
	je short 00000001806AD76Fh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,1
	call 0000000180002040h
	mov rcx,[rsi+18h]
	inc ebp
	mov edx,ebp
	test rcx,rcx
	je short 00000001806AD76Fh
	jmp near ptr 00000001806AD5D3h
	mov rdi,[rsp+78h]
	lea r11,[rsp+50h]
	mov rbp,[r11+30h]
	mov rsi,[r11+38h]
	mov rbx,[rsp+70h]
	mov rsp,r11
	pop r15
	pop r14
	pop r12
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x18, rbp
	002 Move stack:0x20, rsi
	003 ShiftStack -8
	004 Move stack:0x0, r12
	005 ShiftStack -8
	006 Move stack:0x0, r14
	007 ShiftStack -8
	008 Move stack:0x0, r15
	009 ShiftStack -80
	010 Compare [0x184EEB647], 0
	011 Move r14, r8
	012 Move r15, rdx
	013 Move rsi, rcx
	014 JumpIfNotEqual {24}
	015 LoadAddress rcx, [0x184C2AFC0]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C81450]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 LoadAddress rcx, [0x184C81528]
	020 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	021 LoadAddress rcx, [0x184C75168]
	022 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	023 Move [0x184EEB647], 1
	024 Move xmm0, 0
	025 Move stack:0x70, rbx
	026 Move xmm1, 0
	027 Move stack:0x78, rdi
	028 Move r8, 0
	029 Move rdx, 0
	030 Move rcx, rsi
	031 Move stack:0x30, xmm0
	032 Move stack:0x20, xmm1
	033 Call Plant.GetDamageRangeFlags, rcx, rdx
	034 Move r9, 0
	035 LoadAddress rcx, stack:0x40
	036 Move r8, 0
	037 Move rdx, rsi
	038 Move r12, rax
	039 Call Plant.GetPlantAttackRect, rcx, rdx
	040 Move rcx, [rsi+24]
	041 Move rbp, 0
	042 Move rdx, 0
	043 Move xmm0, [rax]
	044 Move stack:0x30, xmm0
	045 Compare rcx, 0
	046 JumpIfEqual {160}
	047 Move rax, [rcx+112]
	048 Compare rax, 0
	049 JumpIfEqual {160}
	050 Compare rdx, [rax+40]
	051 JumpIfGreaterOrEqual {147}
	052 Move rax, [rsi+24]
	053 Compare rax, 0
	054 JumpIfEqual {160}
	055 Move rcx, [rax+112]
	056 Compare rcx, 0
	057 JumpIfEqual {160}
	058 Move r8, [0x184C81528]
	059 Move rdx, rbp
	060 Call 0x182449330, rcx, rdx
	061 Move rdi, rax
	062 Compare rax, 0
	063 JumpIfEqual {160}
	064 Move rcx, [rax+52]
	065 Move rax, 0
	066 Subtract rcx, rcx, [rsi+52]
	067 Compare [rdi+112], 25
	068 JumpIfEqual {70}
	069 Move rax, rcx
	070 Nop 
	071 Compare [rsi+112], 42
	072 JumpIfEqual {76}
	073 Compare rax, 0
	074 JumpIfNotEqual {141}
	075 Goto {79}
	076 Add rax, rax, 1
	077 Compare rax, 2
	078 JumpIfGreater {141}
	079 Move rbx, [rdi+278]
	080 Move rdx, 0
	081 Move rcx, rsi
	082 Call Plant.IsOnHighGround, rcx, rdx
	083 Compare rbx, rax
	084 JumpIfNotEqual {141}
	085 Move r8, 0
	086 Move rdx, r12
	087 Move rcx, rdi
	088 Call Zombie.EffectedByDamage, rcx, rdx
	089 Compare rax, 0
	090 JumpIfEqual {141}
	091 Move r8, 0
	092 LoadAddress rcx, stack:0x40
	093 Move rdx, rdi
	094 Call Zombie.GetZombieRect, rcx, rdx
	095 Move rcx, typeof(Reloaded.Gameplay.Common)
	096 Move xmm0, [rax]
	097 Move stack:0x20, xmm0
	098 Compare [rcx+228], 0
	099 JumpIfNotEqual {101}
	100 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	101 Move r8, 0
	102 LoadAddress rdx, stack:0x20
	103 LoadAddress rcx, stack:0x30
	104 Call Common.GetRectOverlap, rcx, rdx, r8
	105 Compare rax, 0
	106 JumpIfLessOrEqual {141}
	107 Compare [rdi+112], 12
	108 Move rbx, r15
	109 JumpIfEqual {112}
	110 Compare [rdi+112], 22
	111 JumpIfNotEqual {126}
	112 Move rcx, typeof(Reloaded.Gameplay.Common)
	113 Compare [rcx+228], 0
	114 JumpIfNotEqual {116}
	115 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	116 Compare r14, 32
	117 JumpIfLessOrEqual {126}
	118 Move rbx, 1800
	119 Move rdx, 0
	120 Move rcx, rsi
	121 Compare [rsi+112], 46
	122 JumpIfEqual {125}
	123 Call Plant.Die, rcx, rdx
	124 Goto {126}
	125 Call Plant.SpikeRockTakeDamage, rcx, rdx
	126 Move r9, 0
	127 Move r8, r14
	128 Move rdx, rbx
	129 Move rcx, rdi
	130 Call Zombie.TakeDamage, rcx, rdx, r8
	131 Move r8, [rsi+16]
	132 Compare r8, 0
	133 JumpIfEqual {160}
	134 Move r8, [r8+88]
	135 Compare r8, 0
	136 JumpIfEqual {160}
	137 Move rdx, typeof(Reloaded.Services.IAudioService)
	138 Move rcx, 6
	139 Move r9, 1
	140 Call 0x180002040, rcx, rdx, r8, r9
	141 Move rcx, [rsi+24]
	142 Add rbp, rbp, 1
	143 Move rdx, rbp
	144 Compare rcx, 0
	145 JumpIfEqual {160}
	146 Goto {47}
	147 Move rdi, stack:0x78
	148 LoadAddress r11, stack:0x50
	149 Move rbp, [r11+48]
	150 Move rsi, [r11+56]
	151 Move rbx, stack:0x70
	152 Move rsp, r11
	153 Move r15, stack:0x0
	154 ShiftStack 8
	155 Move r14, stack:0x0
	156 ShiftStack 8
	157 Move r12, stack:0x0
	158 ShiftStack 8
	159 Return 
	160 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
