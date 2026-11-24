# System.Boolean FindStarFruitTarget()

- 类：`Plant`
- 汇编行数：421

## 反汇编

```asm

Disassembly:
	push rdi
	sub rsp,0F0h
	cmp byte ptr [184EEB654h],0
	mov rdi,rcx
	jne short 00000001806AF790h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	mov byte ptr [184EEB654h],1
	cmp dword ptr [rdi+100h],0
	mov [rsp+100h],rbx
	mov [rsp+108h],rbp
	mov [rsp+110h],rsi
	mov [rsp+118h],r14
	movaps [rsp+0E0h],xmm6
	movaps [rsp+0D0h],xmm7
	movaps [rsp+0C0h],xmm8
	movaps [rsp+0B0h],xmm9
	movaps [rsp+0A0h],xmm10
	movaps [rsp+90h],xmm11
	movaps [rsp+80h],xmm12
	movaps [rsp+70h],xmm13
	movaps [rsp+60h],xmm14
	movaps [rsp+50h],xmm15
	jg near ptr 00000001806AFA9Dh
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 00000001806B12F0h
	movss xmm10,dword ptr [183C33DC4h]
	xor r14d,r14d
	mov rcx,[rdi+18h]
	mov ebp,eax
	movss xmm9,dword ptr [rdi+20h]
	mov esi,r14d
	movss xmm12,dword ptr [rdi+24h]
	addss xmm9,xmm10
	addss xmm12,xmm10
	mov edx,r14d
	test rcx,rcx
	je near ptr 00000001806AFB17h
	movss xmm11,dword ptr [183C33C40h]
	movss xmm13,dword ptr [183C33DC0h]
	movss xmm14,dword ptr [183C33F58h]
	movss xmm15,dword ptr [183C33DBCh]
	nop dword ptr [rax]
	nop dword ptr [rax+rax]
	mov rax,[rcx+70h]
	test rax,rax
	je near ptr 00000001806AFB17h
	cmp edx,[rax+28h]
	jge near ptr 00000001806AFA99h
	mov rax,[rdi+18h]
	test rax,rax
	je near ptr 00000001806AFB17h
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AFB17h
	mov r8,[184C81528h]
	mov edx,esi
	call 0000000182449330h
	mov rbx,rax
	test rax,rax
	je near ptr 00000001806AFB17h
	xor r8d,r8d
	lea rcx,[rsp+40h]
	mov rdx,rax
	call 00000001806F2D70h
	xor r8d,r8d
	mov edx,ebp
	mov rcx,rbx
	movups xmm6,[rax]
	movups [rsp+30h],xmm6
	call 00000001806F12F0h
	test al,al
	je near ptr 00000001806AFA83h
	cmp dword ptr [rbx+70h],19h
	jne short 00000001806AF907h
	cmp dword ptr [rdi+74h],5
	jge near ptr 00000001806AFA9Dh
	mov eax,[rdi+34h]
	cmp [rbx+34h],eax
	je near ptr 00000001806AFA72h
	cmp dword ptr [rbx+70h],11h
	movss xmm6,dword ptr [rsp+38h]
	jne short 00000001806AF927h
	addss xmm6,dword ptr [183C33DACh]
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r14d
	jne short 00000001806AF93Ch
	call 00000001804FEEB0h
	movss xmm7,dword ptr [rsp+3Ch]
	movaps xmm2,xmm6
	movss xmm8,dword ptr [rsp+34h]
	movaps xmm3,xmm7
	mulss xmm3,xmm11
	movaps xmm1,xmm12
	mov [rsp+20h],r14
	mulss xmm2,xmm11
	movaps xmm0,xmm9
	addss xmm3,xmm8
	addss xmm2,dword ptr [rsp+30h]
	call 00000001806CB840h
	divss xmm0,dword ptr [183C33FA0h]
	xor r8d,r8d
	mov rcx,rbx
	movaps xmm1,xmm0
	call 000000018070A110h
	movaps xmm1,xmm0
	movaps xmm0,xmm6
	mulss xmm0,xmm11
	subss xmm1,xmm0
	cvttss2si eax,xmm1
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	addss xmm0,xmm6
	comiss xmm0,xmm9
	jbe short 00000001806AF9C1h
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	comiss xmm9,xmm0
	ja near ptr 00000001806AFA9Dh
	mulss xmm6,xmm11
	xor r8d,r8d
	mulss xmm7,xmm11
	movd xmm2,eax
	cvtdq2ps xmm2,xmm2
	addss xmm7,xmm8
	addss xmm6,xmm2
	subss xmm7,xmm12
	subss xmm6,xmm9
	movaps xmm0,xmm7
	movaps xmm1,xmm6
	call 00000001806AB010h
	mov rcx,[184C2AFC0h]
	movaps xmm6,xmm0
	cmp [rcx+0E4h],r14d
	jne short 00000001806AFA0Bh
	call 00000001804FEEB0h
	xor edx,edx
	movaps xmm0,xmm6
	call 00000001806CBD30h
	mov edx,[rdi+34h]
	mov ecx,[rbx+34h]
	sub ecx,edx
	sub edx,[rbx+34h]
	cmp edx,ecx
	cmovle edx,ecx
	cmp edx,2
	jl short 00000001806AFA50h
	comiss xmm0,xmm13
	jbe short 00000001806AFA3Dh
	movss xmm1,dword ptr [183C33EF4h]
	comiss xmm1,xmm0
	ja short 00000001806AFA9Dh
	movss xmm1,dword ptr [183C34018h]
	comiss xmm1,xmm0
	jbe short 00000001806AFA83h
	comiss xmm0,xmm14
	jmp short 00000001806AFA81h
	comiss xmm0,xmm15
	jbe short 00000001806AFA5Ch
	comiss xmm10,xmm0
	ja short 00000001806AFA9Dh
	movss xmm1,dword ptr [183C33F50h]
	comiss xmm1,xmm0
	jbe short 00000001806AFA83h
	comiss xmm0,dword ptr [183C3401Ch]
	jmp short 00000001806AFA81h
	movaps xmm0,xmm6
	shufps xmm0,xmm6,0AAh
	addss xmm0,xmm6
	comiss xmm9,xmm0
	ja short 00000001806AFA9Dh
	mov rcx,[rdi+18h]
	inc esi
	mov edx,esi
	test rcx,rcx
	je near ptr 00000001806AFB17h
	jmp near ptr 00000001806AF880h
	xor al,al
	jmp short 00000001806AFA9Fh
	mov al,1
	movaps xmm15,[rsp+50h]
	movaps xmm14,[rsp+60h]
	movaps xmm13,[rsp+70h]
	movaps xmm12,[rsp+80h]
	movaps xmm11,[rsp+90h]
	movaps xmm10,[rsp+0A0h]
	movaps xmm9,[rsp+0B0h]
	movaps xmm8,[rsp+0C0h]
	movaps xmm7,[rsp+0D0h]
	movaps xmm6,[rsp+0E0h]
	mov r14,[rsp+118h]
	mov rsi,[rsp+110h]
	mov rbp,[rsp+108h]
	mov rbx,[rsp+100h]
	add rsp,0F0h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rdi
	003 ShiftStack -240
	004 Compare [0x184EEB654], 0
	005 Move rdi, rcx
	006 JumpIfNotEqual {14}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C81450]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C81528]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 Move [0x184EEB654], 1
	014 Compare [rdi+256], 0
	015 Move stack:0x100, rbx
	016 Move stack:0x108, rbp
	017 Move stack:0x110, rsi
	018 Move stack:0x118, r14
	019 Move stack:0xE0, xmm6
	020 Move stack:0xD0, xmm7
	021 Move stack:0xC0, xmm8
	022 Move stack:0xB0, xmm9
	023 Move stack:0xA0, xmm10
	024 Move stack:0x90, xmm11
	025 Move stack:0x80, xmm12
	026 Move stack:0x70, xmm13
	027 Move stack:0x60, xmm14
	028 Move stack:0x50, xmm15
	029 JumpIfGreater {193}
	030 Move r8, 0
	031 Move rdx, 0
	032 Move rcx, rdi
	033 Call Plant.GetDamageRangeFlags, rcx, rdx
	034 Move xmm10, [0x183C33DC4]
	035 Move r14, 0
	036 Move rcx, [rdi+24]
	037 Move rbp, rax
	038 Move xmm9, [rdi+32]
	039 Move rsi, r14
	040 Move xmm12, [rdi+36]
	041 Add xmm9, xmm9, xmm10
	042 Add xmm12, xmm12, xmm10
	043 Move rdx, r14
	044 Compare rcx, 0
	045 JumpIfEqual {212}
	046 Move xmm11, [0x183C33C40]
	047 Move xmm13, [0x183C33DC0]
	048 Move xmm14, [0x183C33F58]
	049 Move xmm15, [0x183C33DBC]
	050 Nop 
	051 Nop 
	052 Move rax, [rcx+112]
	053 Compare rax, 0
	054 JumpIfEqual {212}
	055 Compare rdx, [rax+40]
	056 JumpIfGreaterOrEqual {191}
	057 Move rax, [rdi+24]
	058 Compare rax, 0
	059 JumpIfEqual {212}
	060 Move rcx, [rax+112]
	061 Compare rcx, 0
	062 JumpIfEqual {212}
	063 Move r8, [0x184C81528]
	064 Move rdx, rsi
	065 Call 0x182449330, rcx, rdx
	066 Move rbx, rax
	067 Compare rax, 0
	068 JumpIfEqual {212}
	069 Move r8, 0
	070 LoadAddress rcx, stack:0x40
	071 Move rdx, rax
	072 Call Zombie.GetZombieRect, rcx, rdx
	073 Move r8, 0
	074 Move rdx, rbp
	075 Move rcx, rbx
	076 Move xmm6, [rax]
	077 Move stack:0x30, xmm6
	078 Call Zombie.EffectedByDamage, rcx, rdx
	079 Compare rax, 0
	080 JumpIfEqual {185}
	081 Compare [rbx+112], 25
	082 JumpIfNotEqual {85}
	083 Compare [rdi+116], 5
	084 JumpIfGreaterOrEqual {193}
	085 Move rax, [rdi+52]
	086 Compare [rbx+52], rax
	087 JumpIfEqual {176}
	088 Compare [rbx+112], 17
	089 Move xmm6, stack:0x38
	090 JumpIfNotEqual {92}
	091 Add xmm6, xmm6, [0x183C33DAC]
	092 Move rcx, typeof(Reloaded.Gameplay.Common)
	093 Compare [rcx+228], r14
	094 JumpIfNotEqual {96}
	095 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	096 Move xmm7, stack:0x3C
	097 Move xmm2, xmm6
	098 Move xmm8, stack:0x34
	099 Move xmm3, xmm7
	100 Multiply xmm3, xmm3, xmm11
	101 Move xmm1, xmm12
	102 Move stack:0x20, r14
	103 Multiply xmm2, xmm2, xmm11
	104 Move xmm0, xmm9
	105 Add xmm3, xmm3, xmm8
	106 Add xmm2, xmm2, stack:0x30
	107 Call Common.Distance2D, xmm0, xmm1, xmm2, xmm3, stack:0x0
	108 Divide xmm0, xmm0, [0x183C33FA0]
	109 Move r8, 0
	110 Move rcx, rbx
	111 Move xmm1, xmm0
	112 Call Zombie.ZombieTargetLeadX, rcx, rdx
	113 Move xmm1, xmm0
	114 Move xmm0, xmm6
	115 Multiply xmm0, xmm0, xmm11
	116 Subtract xmm1, xmm1, xmm0
	117 NotImplemented "cvttss2si eax,xmm1"
	118 Move xmm0, rax
	119 Move xmm0, xmm0
	120 Add xmm0, xmm0, xmm6
	121 Compare xmm0, xmm9
	122 JumpIfLessOrEqual {127}
	123 Move xmm0, rax
	124 Move xmm0, xmm0
	125 Compare xmm9, xmm0
	126 JumpIfGreater {193}
	127 Multiply xmm6, xmm6, xmm11
	128 Move r8, 0
	129 Multiply xmm7, xmm7, xmm11
	130 Move xmm2, rax
	131 Move xmm2, xmm2
	132 Add xmm7, xmm7, xmm8
	133 Add xmm6, xmm6, xmm2
	134 Subtract xmm7, xmm7, xmm12
	135 Subtract xmm6, xmm6, xmm9
	136 Move xmm0, xmm7
	137 Move xmm1, xmm6
	138 Call 0x1806AB010, rcx, rdx, r8, r9
	139 Move rcx, typeof(Reloaded.Gameplay.Common)
	140 Move xmm6, xmm0
	141 Compare [rcx+228], r14
	142 JumpIfNotEqual {144}
	143 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	144 Move rdx, 0
	145 Move xmm0, xmm6
	146 Call Common.RadToDeg, xmm0, rdx
	147 Move rdx, [rdi+52]
	148 Move rcx, [rbx+52]
	149 Subtract rcx, rcx, rdx
	150 Subtract rdx, rdx, [rbx+52]
	151 Compare rdx, rcx
	152 JumpIfGreater {154}
	153 Move rdx, rcx
	154 Nop 
	155 Compare rdx, 2
	156 JumpIfLess {167}
	157 Compare xmm0, xmm13
	158 JumpIfLessOrEqual {162}
	159 Move xmm1, [0x183C33EF4]
	160 Compare xmm1, xmm0
	161 JumpIfGreater {193}
	162 Move xmm1, [0x183C34018]
	163 Compare xmm1, xmm0
	164 JumpIfLessOrEqual {185}
	165 Compare xmm0, xmm14
	166 Goto {184}
	167 Compare xmm0, xmm15
	168 JumpIfLessOrEqual {171}
	169 Compare xmm10, xmm0
	170 JumpIfGreater {193}
	171 Move xmm1, [0x183C33F50]
	172 Compare xmm1, xmm0
	173 JumpIfLessOrEqual {185}
	174 Compare xmm0, [0x183C3401C]
	175 Goto {184}
	176 Move xmm0, xmm6
	177 Move XMM_TEMP.S[0], xmm0.S[2]
	178 Move XMM_TEMP.S[1], xmm0.S[2]
	179 Move XMM_TEMP.S[2], xmm6.S[2]
	180 Move XMM_TEMP.S[3], xmm6.S[2]
	181 Move xmm0, XMM_TEMP
	182 Add xmm0, xmm0, xmm6
	183 Compare xmm9, xmm0
	184 JumpIfGreater {193}
	185 Move rcx, [rdi+24]
	186 Add rsi, rsi, 1
	187 Move rdx, rsi
	188 Compare rcx, 0
	189 JumpIfEqual {212}
	190 Goto {52}
	191 Move rax, 0
	192 Goto {194}
	193 Move rax, 1
	194 Move xmm15, stack:0x50
	195 Move xmm14, stack:0x60
	196 Move xmm13, stack:0x70
	197 Move xmm12, stack:0x80
	198 Move xmm11, stack:0x90
	199 Move xmm10, stack:0xA0
	200 Move xmm9, stack:0xB0
	201 Move xmm8, stack:0xC0
	202 Move xmm7, stack:0xD0
	203 Move xmm6, stack:0xE0
	204 Move r14, stack:0x118
	205 Move rsi, stack:0x110
	206 Move rbp, stack:0x108
	207 Move rbx, stack:0x100
	208 ShiftStack 240
	209 Move rdi, stack:0x0
	210 ShiftStack 8
	211 Return rax
	212 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
