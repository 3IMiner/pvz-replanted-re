# Reloaded.Gameplay.Zombie FindSquashTarget()

- 类：`Plant`
- 汇编行数：471

## 反汇编

```asm

Disassembly:
	push rdi
	push r12
	push r13
	push r14
	push r15
	sub rsp,80h
	cmp byte ptr [184EEB648h],0
	mov rdi,rcx
	jne short 00000001806AF418h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	mov byte ptr [184EEB648h],1
	mov [rsp+0B0h],rbx
	xorps xmm0,xmm0
	mov [rsp+0B8h],rbp
	xor r8d,r8d
	mov [rsp+0C0h],rsi
	xor edx,edx
	movaps [rsp+70h],xmm6
	mov rcx,rdi
	movaps [rsp+60h],xmm7
	movaps [rsp+50h],xmm8
	movups [rsp+20h],xmm0
	call 00000001806B12F0h
	xor r9d,r9d
	lea rcx,[rsp+40h]
	xor r8d,r8d
	mov rdx,rdi
	mov r13d,eax
	call 00000001806B1660h
	xor r12d,r12d
	xor r15d,r15d
	xor r14d,r14d
	xor edx,edx
	movups xmm2,[rax]
	mov rax,[rdi+18h]
	movss dword ptr [rsp+30h],xmm2
	movaps xmm0,xmm2
	shufps xmm0,xmm2,55h
	movaps xmm1,xmm2
	shufps xmm1,xmm2,0AAh
	shufps xmm2,xmm2,0FFh
	movss dword ptr [rsp+3Ch],xmm2
	movss dword ptr [rsp+34h],xmm0
	movss dword ptr [rsp+38h],xmm1
	test rax,rax
	je near ptr 00000001806AF740h
	movss xmm7,dword ptr [183C33DBCh]
	mov esi,46h
	movss xmm8,dword ptr [183C33C68h]
	nop word ptr [rax+rax]
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AF740h
	cmp edx,[rcx+28h]
	jge near ptr 00000001806AF73Bh
	mov rax,[rdi+18h]
	test rax,rax
	je near ptr 00000001806AF740h
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AF740h
	mov r8,[184C81528h]
	mov edx,r14d
	call 0000000182449330h
	mov rbx,rax
	test rax,rax
	je near ptr 00000001806AF740h
	mov eax,[rax+34h]
	sub eax,[rdi+34h]
	cmp dword ptr [rbx+70h],24h
	je near ptr 00000001806AF6EBh
	xor ecx,ecx
	cmp dword ptr [rbx+70h],19h
	cmovne ecx,eax
	test ecx,ecx
	jne near ptr 00000001806AF6EBh
	cmp [rbx+112h],cl
	je near ptr 00000001806AF6EBh
	xor edx,edx
	mov rcx,rbx
	call 00000001806F3830h
	test al,al
	jne near ptr 00000001806AF6EBh
	xor r8d,r8d
	mov edx,r13d
	mov rcx,rbx
	call 00000001806F12F0h
	test al,al
	je near ptr 00000001806AF6EBh
	xor r8d,r8d
	lea rcx,[rsp+40h]
	mov rdx,rbx
	call 00000001806F2D70h
	movups xmm2,[rax]
	movaps xmm0,xmm2
	movss dword ptr [rsp+20h],xmm2
	shufps xmm0,xmm2,55h
	movaps xmm1,xmm2
	movss dword ptr [rsp+24h],xmm0
	movaps xmm0,xmm2
	shufps xmm0,xmm2,0FFh
	shufps xmm1,xmm2,0AAh
	movss dword ptr [rsp+2Ch],xmm0
	movss dword ptr [rsp+28h],xmm1
	cmp dword ptr [rbx+74h],0Bh
	jne short 00000001806AF5CEh
	movss xmm0,dword ptr [rdi+20h]
	addss xmm0,xmm7
	comiss xmm0,xmm2
	ja short 00000001806AF612h
	cmp dword ptr [rbx+74h],0Bh
	je near ptr 00000001806AF6EBh
	cmp dword ptr [rbx+74h],0Ch
	je near ptr 00000001806AF6EBh
	cmp dword ptr [rbx+74h],3Ah
	je near ptr 00000001806AF6EBh
	cmp dword ptr [rbx+74h],34h
	je near ptr 00000001806AF6EBh
	cmp dword ptr [rbx+74h],35h
	je near ptr 00000001806AF6EBh
	cmp dword ptr [rbx+74h],36h
	je near ptr 00000001806AF6EBh
	xor edx,edx
	mov rcx,rbx
	call 00000001806F35C0h
	test al,al
	jne near ptr 00000001806AF6EBh
	cmp byte ptr [rbx+0A5h],0
	mov ebp,6Eh
	mov rcx,[184C2AFC0h]
	cmove ebp,esi
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AF636h
	call 00000001804FEEB0h
	xor r8d,r8d
	lea rdx,[rsp+20h]
	lea rcx,[rsp+30h]
	call 00000001806CBAA0h
	mov esi,eax
	neg esi
	cmp esi,ebp
	jg near ptr 00000001806AF6E6h
	cmp dword ptr [rbx+74h],0Dh
	movss xmm6,dword ptr [rsp+30h]
	je short 00000001806AF696h
	cmp dword ptr [rbx+74h],0Bh
	je short 00000001806AF696h
	cmp dword ptr [rbx+74h],37h
	je short 00000001806AF696h
	cmp dword ptr [rbx+70h],18h
	je short 00000001806AF696h
	cmp dword ptr [rbx+70h],7
	je short 00000001806AF696h
	mov rcx,[rdi+10h]
	test rcx,rcx
	je near ptr 00000001806AF740h
	xor edx,edx
	call 00000001807DF7E0h
	test al,al
	je short 00000001806AF69Bh
	movss xmm6,dword ptr [rsp+30h]
	subss xmm6,xmm8
	xor edx,edx
	mov rcx,rbx
	call 00000001806F3A20h
	test al,al
	jne short 00000001806AF6BAh
	movss xmm0,dword ptr [rsp+28h]
	addss xmm0,dword ptr [rsp+20h]
	comiss xmm6,xmm0
	ja short 00000001806AF6E6h
	mov rcx,[rdi+18h]
	test rcx,rcx
	je short 00000001806AF740h
	xor r8d,r8d
	mov rdx,rbx
	call 0000000180676EB0h
	cmp eax,[rdi+120h]
	je short 00000001806AF6FFh
	test r15,r15
	je short 00000001806AF6E0h
	cmp esi,r12d
	jge short 00000001806AF6E6h
	mov r15,rbx
	mov r12d,esi
	mov esi,46h
	mov rax,[rdi+18h]
	inc r14d
	mov edx,r14d
	test rax,rax
	je short 00000001806AF740h
	jmp near ptr 00000001806AF4D0h
	mov rax,rbx
	movaps xmm8,[rsp+50h]
	movaps xmm7,[rsp+60h]
	movaps xmm6,[rsp+70h]
	mov rsi,[rsp+0C0h]
	mov rbp,[rsp+0B8h]
	mov rbx,[rsp+0B0h]
	add rsp,80h
	pop r15
	pop r14
	pop r13
	pop r12
	pop rdi
	ret
	mov rax,r15
	jmp short 00000001806AF702h
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rdi
	003 ShiftStack -8
	004 Move stack:0x0, r12
	005 ShiftStack -8
	006 Move stack:0x0, r13
	007 ShiftStack -8
	008 Move stack:0x0, r14
	009 ShiftStack -8
	010 Move stack:0x0, r15
	011 ShiftStack -128
	012 Compare [0x184EEB648], 0
	013 Move rdi, rcx
	014 JumpIfNotEqual {22}
	015 LoadAddress rcx, [0x184C2AFC0]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C81450]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 LoadAddress rcx, [0x184C81528]
	020 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	021 Move [0x184EEB648], 1
	022 Move stack:0xB0, rbx
	023 Move xmm0, 0
	024 Move stack:0xB8, rbp
	025 Move r8, 0
	026 Move stack:0xC0, rsi
	027 Move rdx, 0
	028 Move stack:0x70, xmm6
	029 Move rcx, rdi
	030 Move stack:0x60, xmm7
	031 Move stack:0x50, xmm8
	032 Move stack:0x20, xmm0
	033 Call Plant.GetDamageRangeFlags, rcx, rdx
	034 Move r9, 0
	035 LoadAddress rcx, stack:0x40
	036 Move r8, 0
	037 Move rdx, rdi
	038 Move r13, rax
	039 Call Plant.GetPlantAttackRect, rcx, rdx
	040 Move r12, 0
	041 Move r15, 0
	042 Move r14, 0
	043 Move rdx, 0
	044 Move xmm2, [rax]
	045 Move rax, [rdi+24]
	046 Move stack:0x30, xmm2
	047 Move xmm0, xmm2
	048 Move XMM_TEMP.S[0], xmm0.S[1]
	049 Move XMM_TEMP.S[1], xmm0.S[1]
	050 Move XMM_TEMP.S[2], xmm2.S[1]
	051 Move XMM_TEMP.S[3], xmm2.S[1]
	052 Move xmm0, XMM_TEMP
	053 Move xmm1, xmm2
	054 Move XMM_TEMP.S[0], xmm1.S[2]
	055 Move XMM_TEMP.S[1], xmm1.S[2]
	056 Move XMM_TEMP.S[2], xmm2.S[2]
	057 Move XMM_TEMP.S[3], xmm2.S[2]
	058 Move xmm1, XMM_TEMP
	059 Move XMM_TEMP.S[0], xmm2.S[3]
	060 Move XMM_TEMP.S[1], xmm2.S[3]
	061 Move XMM_TEMP.S[2], xmm2.S[3]
	062 Move XMM_TEMP.S[3], xmm2.S[3]
	063 Move xmm2, XMM_TEMP
	064 Move stack:0x3C, xmm2
	065 Move stack:0x34, xmm0
	066 Move stack:0x38, xmm1
	067 Compare rax, 0
	068 JumpIfEqual {252}
	069 Move xmm7, [0x183C33DBC]
	070 Move rsi, 70
	071 Move xmm8, [0x183C33C68]
	072 Nop 
	073 Move rcx, [rax+112]
	074 Compare rcx, 0
	075 JumpIfEqual {252}
	076 Compare rdx, [rcx+40]
	077 JumpIfGreaterOrEqual {250}
	078 Move rax, [rdi+24]
	079 Compare rax, 0
	080 JumpIfEqual {252}
	081 Move rcx, [rax+112]
	082 Compare rcx, 0
	083 JumpIfEqual {252}
	084 Move r8, [0x184C81528]
	085 Move rdx, r14
	086 Call 0x182449330, rcx, rdx
	087 Move rbx, rax
	088 Compare rax, 0
	089 JumpIfEqual {252}
	090 Move rax, [rax+52]
	091 Subtract rax, rax, [rdi+52]
	092 Compare [rbx+112], 36
	093 JumpIfEqual {225}
	094 Move rcx, 0
	095 Compare [rbx+112], 25
	096 JumpIfEqual {98}
	097 Move rcx, rax
	098 Nop 
	099 Compare rcx, 0
	100 JumpIfNotEqual {225}
	101 Compare [rbx+274], rcx
	102 JumpIfEqual {225}
	103 Move rdx, 0
	104 Move rcx, rbx
	105 Call Zombie.IsTangleKelpTarget, rcx, rdx
	106 Compare rax, 0
	107 JumpIfNotEqual {225}
	108 Move r8, 0
	109 Move rdx, r13
	110 Move rcx, rbx
	111 Call Zombie.EffectedByDamage, rcx, rdx
	112 Compare rax, 0
	113 JumpIfEqual {225}
	114 Move r8, 0
	115 LoadAddress rcx, stack:0x40
	116 Move rdx, rbx
	117 Call Zombie.GetZombieRect, rcx, rdx
	118 Move xmm2, [rax]
	119 Move xmm0, xmm2
	120 Move stack:0x20, xmm2
	121 Move XMM_TEMP.S[0], xmm0.S[1]
	122 Move XMM_TEMP.S[1], xmm0.S[1]
	123 Move XMM_TEMP.S[2], xmm2.S[1]
	124 Move XMM_TEMP.S[3], xmm2.S[1]
	125 Move xmm0, XMM_TEMP
	126 Move xmm1, xmm2
	127 Move stack:0x24, xmm0
	128 Move xmm0, xmm2
	129 Move XMM_TEMP.S[0], xmm0.S[3]
	130 Move XMM_TEMP.S[1], xmm0.S[3]
	131 Move XMM_TEMP.S[2], xmm2.S[3]
	132 Move XMM_TEMP.S[3], xmm2.S[3]
	133 Move xmm0, XMM_TEMP
	134 Move XMM_TEMP.S[0], xmm1.S[2]
	135 Move XMM_TEMP.S[1], xmm1.S[2]
	136 Move XMM_TEMP.S[2], xmm2.S[2]
	137 Move XMM_TEMP.S[3], xmm2.S[2]
	138 Move xmm1, XMM_TEMP
	139 Move stack:0x2C, xmm0
	140 Move stack:0x28, xmm1
	141 Compare [rbx+116], 11
	142 JumpIfNotEqual {149}
	143 Move xmm0, [rdi+32]
	144 Add xmm0, xmm0, xmm7
	145 Compare xmm0, xmm2
	146 JumpIfGreater {164}
	147 Compare [rbx+116], 11
	148 JumpIfEqual {225}
	149 Compare [rbx+116], 12
	150 JumpIfEqual {225}
	151 Compare [rbx+116], 58
	152 JumpIfEqual {225}
	153 Compare [rbx+116], 52
	154 JumpIfEqual {225}
	155 Compare [rbx+116], 53
	156 JumpIfEqual {225}
	157 Compare [rbx+116], 54
	158 JumpIfEqual {225}
	159 Move rdx, 0
	160 Move rcx, rbx
	161 Call Zombie.IsBobsledTeamWithSled, rcx, rdx
	162 Compare rax, 0
	163 JumpIfNotEqual {225}
	164 Compare [rbx+165], 0
	165 Move rbp, 110
	166 Move rcx, typeof(Reloaded.Gameplay.Common)
	167 JumpIfNotEqual {169}
	168 Move rbp, rsi
	169 Nop 
	170 Compare [rcx+228], 0
	171 JumpIfNotEqual {173}
	172 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	173 Move r8, 0
	174 LoadAddress rdx, stack:0x20
	175 LoadAddress rcx, stack:0x30
	176 Call Common.GetRectOverlap, rcx, rdx, r8
	177 Move rsi, rax
	178 Neg rsi
	179 Compare rsi, rbp
	180 JumpIfGreater {224}
	181 Compare [rbx+116], 13
	182 Move xmm6, stack:0x30
	183 JumpIfEqual {200}
	184 Compare [rbx+116], 11
	185 JumpIfEqual {200}
	186 Compare [rbx+116], 55
	187 JumpIfEqual {200}
	188 Compare [rbx+112], 24
	189 JumpIfEqual {200}
	190 Compare [rbx+112], 7
	191 JumpIfEqual {200}
	192 Move rcx, [rdi+16]
	193 Compare rcx, 0
	194 JumpIfEqual {252}
	195 Move rdx, 0
	196 Call GameplayActivity.IsScaryPotterLevel, rcx, rdx
	197 Compare rax, 0
	198 JumpIfEqual {201}
	199 Move xmm6, stack:0x30
	200 Subtract xmm6, xmm6, xmm8
	201 Move rdx, 0
	202 Move rcx, rbx
	203 Call Zombie.IsWalkingBackwards, rcx, rdx
	204 Compare rax, 0
	205 JumpIfNotEqual {210}
	206 Move xmm0, stack:0x28
	207 Add xmm0, xmm0, stack:0x20
	208 Compare xmm6, xmm0
	209 JumpIfGreater {224}
	210 Move rcx, [rdi+24]
	211 Compare rcx, 0
	212 JumpIfEqual {252}
	213 Move r8, 0
	214 Move rdx, rbx
	215 Call Board.ZombieGetID, rcx, rdx
	216 Compare rax, [rdi+288]
	217 JumpIfEqual {231}
	218 Compare r15, 0
	219 JumpIfEqual {222}
	220 Compare rsi, r12
	221 JumpIfGreaterOrEqual {224}
	222 Move r15, rbx
	223 Move r12, rsi
	224 Move rsi, 70
	225 Move rax, [rdi+24]
	226 Add r14, r14, 1
	227 Move rdx, r14
	228 Compare rax, 0
	229 JumpIfEqual {252}
	230 Goto {73}
	231 Move rax, rbx
	232 Move xmm8, stack:0x50
	233 Move xmm7, stack:0x60
	234 Move xmm6, stack:0x70
	235 Move rsi, stack:0xC0
	236 Move rbp, stack:0xB8
	237 Move rbx, stack:0xB0
	238 ShiftStack 128
	239 Move r15, stack:0x0
	240 ShiftStack 8
	241 Move r14, stack:0x0
	242 ShiftStack 8
	243 Move r13, stack:0x0
	244 ShiftStack 8
	245 Move r12, stack:0x0
	246 ShiftStack 8
	247 Move rdi, stack:0x0
	248 ShiftStack 8
	249 Return rax
	250 Move rax, r15
	251 Goto {232}
	252 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
