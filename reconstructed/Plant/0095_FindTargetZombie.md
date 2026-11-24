# Reloaded.Gameplay.Zombie FindTargetZombie(System.Int32 theRow, Reloaded.Gameplay.PlantWeapon thePlantWeapon)

- 类：`Plant`
- 汇编行数：623

## 反汇编

```asm

Disassembly:
	mov [rsp+20h],rbx
	push rdi
	push r12
	push r13
	push r14
	push r15
	sub rsp,100h
	cmp byte ptr [184EEB63Ch],0
	mov ebx,r8d
	mov r13d,edx
	mov rdi,rcx
	jne short 00000001806B0092h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	mov byte ptr [184EEB63Ch],1
	mov [rsp+130h],rbp
	xorps xmm0,xmm0
	mov [rsp+138h],rsi
	xorps xmm1,xmm1
	movaps [rsp+0F0h],xmm6
	xor r8d,r8d
	movaps [rsp+0E0h],xmm7
	mov edx,ebx
	movaps [rsp+0D0h],xmm8
	mov rcx,rdi
	movaps [rsp+0C0h],xmm9
	movaps [rsp+0B0h],xmm10
	movaps [rsp+0A0h],xmm11
	movaps [rsp+90h],xmm12
	movaps [rsp+80h],xmm13
	movaps [rsp+70h],xmm14
	movaps [rsp+60h],xmm15
	movups [rsp+30h],xmm0
	movups [rsp+40h],xmm1
	call 00000001806B12F0h
	xor r9d,r9d
	mov [rsp+140h],eax
	mov r8d,ebx
	lea rcx,[rsp+50h]
	mov rdx,rdi
	call 00000001806B1660h
	xor r12d,r12d
	xor r15d,r15d
	xor r14d,r14d
	xor edx,edx
	movups xmm0,[rax]
	mov rax,[rdi+18h]
	movups [rsp+30h],xmm0
	test rax,rax
	je near ptr 00000001806B0572h
	movss xmm14,dword ptr [183C33CA0h]
	movss xmm13,dword ptr [183C33DBCh]
	movss xmm12,dword ptr [183C33DC4h]
	movss xmm15,dword ptr [183C33C40h]
	nop
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806B0572h
	cmp edx,[rcx+28h]
	jge near ptr 00000001806B04F4h
	mov rax,[rdi+18h]
	test rax,rax
	je near ptr 00000001806B0572h
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806B0572h
	mov r8,[184C81528h]
	mov edx,r14d
	call 0000000182449330h
	mov rbx,rax
	test rax,rax
	je near ptr 00000001806B0572h
	mov ecx,[rax+34h]
	xor esi,esi
	sub ecx,r13d
	cmp dword ptr [rax+70h],19h
	cmovne esi,ecx
	cmp byte ptr [rax+112h],0
	je short 00000001806B01E1h
	xor edx,edx
	mov rcx,rax
	call 00000001806F3830h
	test al,al
	je short 00000001806B01FFh
	cmp dword ptr [rdi+70h],4
	je near ptr 00000001806B04DCh
	cmp dword ptr [rdi+70h],6
	je near ptr 00000001806B04DCh
	cmp dword ptr [rdi+70h],13h
	je near ptr 00000001806B04DCh
	mov rcx,[rdi+10h]
	xor bpl,bpl
	test rcx,rcx
	je near ptr 00000001806B0572h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,1Ah
	jne short 00000001806B022Fh
	cmp dword ptr [rdi+70h],0
	je short 00000001806B022Ch
	cmp [rdi+70h],eax
	je short 00000001806B022Ch
	cmp dword ptr [rdi+70h],7
	jne short 00000001806B022Fh
	mov bpl,1
	cmp dword ptr [rdi+70h],2Bh
	je short 00000001806B028Ah
	cmp dword ptr [rdi+70h],2Ah
	je short 00000001806B027Eh
	test bpl,bpl
	jne short 00000001806B024Ah
	test esi,esi
	jne near ptr 00000001806B04DCh
	jmp short 00000001806B028Ah
	mov rax,[rdi+18h]
	test rax,rax
	je near ptr 00000001806B0572h
	mov rcx,[rax+110h]
	test rcx,rcx
	je near ptr 00000001806B0572h
	xor r9d,r9d
	mov r8,rbx
	mov rdx,rdi
	call 000000018067DB70h
	test al,al
	jne short 00000001806B028Ah
	jmp near ptr 00000001806B04DCh
	lea eax,[rsi+1]
	cmp eax,2
	ja near ptr 00000001806B04DCh
	mov edx,[rsp+140h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806F12F0h
	test al,al
	je near ptr 00000001806B04DCh
	xor esi,esi
	cmp dword ptr [rdi+70h],6
	jne short 00000001806B0314h
	cmp dword ptr [rbx+70h],24h
	je near ptr 00000001806B04DCh
	cmp dword ptr [rbx+74h],25h
	jne short 00000001806B02DEh
	movss xmm0,dword ptr [rsp+30h]
	addss xmm0,xmm13
	movss dword ptr [rsp+30h],xmm0
	movss xmm1,dword ptr [rsp+38h]
	subss xmm1,xmm13
	movss dword ptr [rsp+38h],xmm1
	cmp dword ptr [rbx+74h],14h
	je near ptr 00000001806B04DCh
	cmp dword ptr [rbx+70h],14h
	jne short 00000001806B02FDh
	mov eax,[rdi+74h]
	cmp [rbx+0D8h],eax
	je near ptr 00000001806B04DCh
	cmp [rbx+0A5h],sil
	jne short 00000001806B030Fh
	cmp dword ptr [rdi+88h],0Ah
	jne short 00000001806B0314h
	mov esi,3Ch
	cmp dword ptr [rdi+70h],4
	jne short 00000001806B038Dh
	cmp dword ptr [rbx+70h],12h
	jne short 00000001806B032Dh
	cmp byte ptr [rbx+114h],0
	jne near ptr 00000001806B04DCh
	cmp dword ptr [rbx+74h],0Ch
	je near ptr 00000001806B04DCh
	cmp dword ptr [rbx+74h],0Bh
	je near ptr 00000001806B04DCh
	cmp dword ptr [rbx+70h],3
	jne short 00000001806B0369h
	movss xmm0,dword ptr [rsp+30h]
	addss xmm0,xmm12
	movss dword ptr [rsp+30h],xmm0
	movss xmm1,dword ptr [rsp+38h]
	subss xmm1,xmm12
	movss dword ptr [rsp+38h],xmm1
	cmp dword ptr [rbx+70h],14h
	jne short 00000001806B037Eh
	mov eax,[rdi+74h]
	cmp [rbx+0D8h],eax
	jne near ptr 00000001806B04DCh
	cmp byte ptr [rbx+0A5h],0
	mov eax,1Eh
	cmovne esi,eax
	cmp dword ptr [rdi+70h],31h
	jne short 00000001806B039Dh
	cmp dword ptr [rbx+74h],0Ch
	je near ptr 00000001806B04DCh
	cmp dword ptr [rdi+70h],13h
	jne short 00000001806B03B0h
	cmp byte ptr [rbx+115h],0
	je near ptr 00000001806B04DCh
	xor r8d,r8d
	lea rcx,[rsp+50h]
	mov rdx,rbx
	call 00000001806F2D70h
	movups xmm6,[rax]
	movss dword ptr [rsp+40h],xmm6
	movaps xmm9,xmm6
	shufps xmm9,xmm6,55h
	movaps xmm7,xmm6
	shufps xmm7,xmm6,0AAh
	movaps xmm8,xmm6
	shufps xmm8,xmm6,0FFh
	movss dword ptr [rsp+44h],xmm9
	movss dword ptr [rsp+48h],xmm7
	movss dword ptr [rsp+4Ch],xmm8
	test bpl,bpl
	jne short 00000001806B0446h
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B0410h
	call 00000001804FEEB0h
	xor r8d,r8d
	lea rdx,[rsp+40h]
	lea rcx,[rsp+30h]
	call 00000001806CBAA0h
	neg esi
	cmp eax,esi
	jl near ptr 00000001806B04DCh
	movss xmm8,dword ptr [rsp+4Ch]
	movss xmm7,dword ptr [rsp+48h]
	movss xmm9,dword ptr [rsp+44h]
	movss xmm6,dword ptr [rsp+40h]
	cmp dword ptr [rdi+70h],2Bh
	movaps xmm0,xmm6
	xorps xmm0,xmm14
	cvttss2si esi,xmm0
	jne short 00000001806B04CCh
	movss xmm10,dword ptr [rdi+20h]
	movss xmm11,dword ptr [rdi+24h]
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B0478h
	call 00000001804FEEB0h
	mulss xmm8,xmm15
	addss xmm11,xmm12
	mov qword ptr [rsp+20h],0
	mulss xmm7,xmm15
	addss xmm10,xmm12
	addss xmm8,xmm9
	movaps xmm1,xmm11
	addss xmm7,xmm6
	movaps xmm0,xmm10
	movaps xmm3,xmm8
	movaps xmm2,xmm7
	call 00000001806CB840h
	cvttss2si esi,xmm0
	xor edx,edx
	mov rcx,rbx
	neg esi
	call 00000001806F3650h
	test al,al
	je short 00000001806B04CCh
	add esi,2710h
	test r15,r15
	je short 00000001806B04D6h
	cmp esi,r12d
	jle short 00000001806B04DCh
	mov r12d,esi
	mov r15,rbx
	mov rax,[rdi+18h]
	inc r14d
	mov edx,r14d
	test rax,rax
	je near ptr 00000001806B0572h
	jmp near ptr 00000001806B0170h
	movaps xmm15,[rsp+60h]
	mov rax,r15
	movaps xmm14,[rsp+70h]
	movaps xmm13,[rsp+80h]
	movaps xmm12,[rsp+90h]
	movaps xmm11,[rsp+0A0h]
	movaps xmm10,[rsp+0B0h]
	movaps xmm9,[rsp+0C0h]
	movaps xmm8,[rsp+0D0h]
	movaps xmm7,[rsp+0E0h]
	movaps xmm6,[rsp+0F0h]
	mov rsi,[rsp+138h]
	mov rbp,[rsp+130h]
	mov rbx,[rsp+148h]
	add rsp,100h
	pop r15
	pop r14
	pop r13
	pop r12
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x20, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -8
	005 Move stack:0x0, r12
	006 ShiftStack -8
	007 Move stack:0x0, r13
	008 ShiftStack -8
	009 Move stack:0x0, r14
	010 ShiftStack -8
	011 Move stack:0x0, r15
	012 ShiftStack -256
	013 Compare [0x184EEB63C], 0
	014 Move rbx, r8
	015 Move r13, rdx
	016 Move rdi, rcx
	017 JumpIfNotEqual {25}
	018 LoadAddress rcx, [0x184C2AFC0]
	019 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	020 LoadAddress rcx, [0x184C81450]
	021 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	022 LoadAddress rcx, [0x184C81528]
	023 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	024 Move [0x184EEB63C], 1
	025 Move stack:0x130, rbp
	026 Move xmm0, 0
	027 Move stack:0x138, rsi
	028 Move xmm1, 0
	029 Move stack:0xF0, xmm6
	030 Move r8, 0
	031 Move stack:0xE0, xmm7
	032 Move rdx, rbx
	033 Move stack:0xD0, xmm8
	034 Move rcx, rdi
	035 Move stack:0xC0, xmm9
	036 Move stack:0xB0, xmm10
	037 Move stack:0xA0, xmm11
	038 Move stack:0x90, xmm12
	039 Move stack:0x80, xmm13
	040 Move stack:0x70, xmm14
	041 Move stack:0x60, xmm15
	042 Move stack:0x30, xmm0
	043 Move stack:0x40, xmm1
	044 Call Plant.GetDamageRangeFlags, rcx, rdx
	045 Move r9, 0
	046 Move stack:0x140, rax
	047 Move r8, rbx
	048 LoadAddress rcx, stack:0x50
	049 Move rdx, rdi
	050 Call Plant.GetPlantAttackRect, rcx, rdx
	051 Move r12, 0
	052 Move r15, 0
	053 Move r14, 0
	054 Move rdx, 0
	055 Move xmm0, [rax]
	056 Move rax, [rdi+24]
	057 Move stack:0x30, xmm0
	058 Compare rax, 0
	059 JumpIfEqual {322}
	060 Move xmm14, [0x183C33CA0]
	061 Move xmm13, [0x183C33DBC]
	062 Move xmm12, [0x183C33DC4]
	063 Move xmm15, [0x183C33C40]
	064 Nop 
	065 Move rcx, [rax+112]
	066 Compare rcx, 0
	067 JumpIfEqual {322}
	068 Compare rdx, [rcx+40]
	069 JumpIfGreaterOrEqual {296}
	070 Move rax, [rdi+24]
	071 Compare rax, 0
	072 JumpIfEqual {322}
	073 Move rcx, [rax+112]
	074 Compare rcx, 0
	075 JumpIfEqual {322}
	076 Move r8, [0x184C81528]
	077 Move rdx, r14
	078 Call 0x182449330, rcx, rdx
	079 Move rbx, rax
	080 Compare rax, 0
	081 JumpIfEqual {322}
	082 Move rcx, [rax+52]
	083 Move rsi, 0
	084 Subtract rcx, rcx, r13
	085 Compare [rax+112], 25
	086 JumpIfEqual {88}
	087 Move rsi, rcx
	088 Nop 
	089 Compare [rax+274], 0
	090 JumpIfEqual {96}
	091 Move rdx, 0
	092 Move rcx, rax
	093 Call Zombie.IsTangleKelpTarget, rcx, rdx
	094 Compare rax, 0
	095 JumpIfEqual {102}
	096 Compare [rdi+112], 4
	097 JumpIfEqual {290}
	098 Compare [rdi+112], 6
	099 JumpIfEqual {290}
	100 Compare [rdi+112], 19
	101 JumpIfEqual {290}
	102 Move rcx, [rdi+16]
	103 Move rbp, 0
	104 Compare rcx, 0
	105 JumpIfEqual {322}
	106 Move rdx, 0
	107 Call GameplayActivity.get_GameMode, rcx, rdx
	108 Compare rax, 26
	109 JumpIfNotEqual {117}
	110 Compare [rdi+112], 0
	111 JumpIfEqual {116}
	112 Compare [rdi+112], rax
	113 JumpIfEqual {116}
	114 Compare [rdi+112], 7
	115 JumpIfNotEqual {117}
	116 Move rbp, 1
	117 Compare [rdi+112], 43
	118 JumpIfEqual {142}
	119 Compare [rdi+112], 42
	120 JumpIfEqual {139}
	121 Compare rbp, 0
	122 JumpIfNotEqual {126}
	123 Compare rsi, 0
	124 JumpIfNotEqual {290}
	125 Goto {142}
	126 Move rax, [rdi+24]
	127 Compare rax, 0
	128 JumpIfEqual {322}
	129 Move rcx, [rax+272]
	130 Compare rcx, 0
	131 JumpIfEqual {322}
	132 Move r9, 0
	133 Move r8, rbx
	134 Move rdx, rdi
	135 Call Challenge.CanTargetZombieWithPortals, rcx, rdx, r8
	136 Compare rax, 0
	137 JumpIfNotEqual {142}
	138 Goto {290}
	139 LoadAddress rax, [rsi+1]
	140 Compare rax, 2
	141 JumpIfGreater {290}
	142 Move rdx, stack:0x140
	143 Move r8, 0
	144 Move rcx, rbx
	145 Call Zombie.EffectedByDamage, rcx, rdx
	146 Compare rax, 0
	147 JumpIfEqual {290}
	148 Move rsi, 0
	149 Compare [rdi+112], 6
	150 JumpIfNotEqual {173}
	151 Compare [rbx+112], 36
	152 JumpIfEqual {290}
	153 Compare [rbx+116], 37
	154 JumpIfNotEqual {161}
	155 Move xmm0, stack:0x30
	156 Add xmm0, xmm0, xmm13
	157 Move stack:0x30, xmm0
	158 Move xmm1, stack:0x38
	159 Subtract xmm1, xmm1, xmm13
	160 Move stack:0x38, xmm1
	161 Compare [rbx+116], 20
	162 JumpIfEqual {290}
	163 Compare [rbx+112], 20
	164 JumpIfNotEqual {168}
	165 Move rax, [rdi+116]
	166 Compare [rbx+216], rax
	167 JumpIfEqual {290}
	168 Compare [rbx+165], rsi
	169 JumpIfNotEqual {172}
	170 Compare [rdi+136], 10
	171 JumpIfNotEqual {173}
	172 Move rsi, 60
	173 Compare [rdi+112], 4
	174 JumpIfNotEqual {201}
	175 Compare [rbx+112], 18
	176 JumpIfNotEqual {179}
	177 Compare [rbx+276], 0
	178 JumpIfNotEqual {290}
	179 Compare [rbx+116], 12
	180 JumpIfEqual {290}
	181 Compare [rbx+116], 11
	182 JumpIfEqual {290}
	183 Compare [rbx+112], 3
	184 JumpIfNotEqual {191}
	185 Move xmm0, stack:0x30
	186 Add xmm0, xmm0, xmm12
	187 Move stack:0x30, xmm0
	188 Move xmm1, stack:0x38
	189 Subtract xmm1, xmm1, xmm12
	190 Move stack:0x38, xmm1
	191 Compare [rbx+112], 20
	192 JumpIfNotEqual {196}
	193 Move rax, [rdi+116]
	194 Compare [rbx+216], rax
	195 JumpIfNotEqual {290}
	196 Compare [rbx+165], 0
	197 Move rax, 30
	198 JumpIfEqual {200}
	199 Move rsi, rax
	200 Nop 
	201 Compare [rdi+112], 49
	202 JumpIfNotEqual {205}
	203 Compare [rbx+116], 12
	204 JumpIfEqual {290}
	205 Compare [rdi+112], 19
	206 JumpIfNotEqual {209}
	207 Compare [rbx+277], 0
	208 JumpIfEqual {290}
	209 Move r8, 0
	210 LoadAddress rcx, stack:0x50
	211 Move rdx, rbx
	212 Call Zombie.GetZombieRect, rcx, rdx
	213 Move xmm6, [rax]
	214 Move stack:0x40, xmm6
	215 Move xmm9, xmm6
	216 Move XMM_TEMP.S[0], xmm9.S[1]
	217 Move XMM_TEMP.S[1], xmm9.S[1]
	218 Move XMM_TEMP.S[2], xmm6.S[1]
	219 Move XMM_TEMP.S[3], xmm6.S[1]
	220 Move xmm9, XMM_TEMP
	221 Move xmm7, xmm6
	222 Move XMM_TEMP.S[0], xmm7.S[2]
	223 Move XMM_TEMP.S[1], xmm7.S[2]
	224 Move XMM_TEMP.S[2], xmm6.S[2]
	225 Move XMM_TEMP.S[3], xmm6.S[2]
	226 Move xmm7, XMM_TEMP
	227 Move xmm8, xmm6
	228 Move XMM_TEMP.S[0], xmm8.S[3]
	229 Move XMM_TEMP.S[1], xmm8.S[3]
	230 Move XMM_TEMP.S[2], xmm6.S[3]
	231 Move XMM_TEMP.S[3], xmm6.S[3]
	232 Move xmm8, XMM_TEMP
	233 Move stack:0x44, xmm9
	234 Move stack:0x48, xmm7
	235 Move stack:0x4C, xmm8
	236 Compare rbp, 0
	237 JumpIfNotEqual {253}
	238 Move rcx, typeof(Reloaded.Gameplay.Common)
	239 Compare [rcx+228], 0
	240 JumpIfNotEqual {242}
	241 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	242 Move r8, 0
	243 LoadAddress rdx, stack:0x40
	244 LoadAddress rcx, stack:0x30
	245 Call Common.GetRectOverlap, rcx, rdx, r8
	246 Neg rsi
	247 Compare rax, rsi
	248 JumpIfLess {290}
	249 Move xmm8, stack:0x4C
	250 Move xmm7, stack:0x48
	251 Move xmm9, stack:0x44
	252 Move xmm6, stack:0x40
	253 Compare [rdi+112], 43
	254 Move xmm0, xmm6
	255 Xor xmm0, xmm0, xmm14
	256 NotImplemented "cvttss2si esi,xmm0"
	257 JumpIfNotEqual {284}
	258 Move xmm10, [rdi+32]
	259 Move xmm11, [rdi+36]
	260 Move rcx, typeof(Reloaded.Gameplay.Common)
	261 Compare [rcx+228], 0
	262 JumpIfNotEqual {264}
	263 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	264 Multiply xmm8, xmm8, xmm15
	265 Add xmm11, xmm11, xmm12
	266 Move stack:0x20, 0
	267 Multiply xmm7, xmm7, xmm15
	268 Add xmm10, xmm10, xmm12
	269 Add xmm8, xmm8, xmm9
	270 Move xmm1, xmm11
	271 Add xmm7, xmm7, xmm6
	272 Move xmm0, xmm10
	273 Move xmm3, xmm8
	274 Move xmm2, xmm7
	275 Call Common.Distance2D, xmm0, xmm1, xmm2, xmm3, stack:0x0
	276 NotImplemented "cvttss2si esi,xmm0"
	277 Move rdx, 0
	278 Move rcx, rbx
	279 Neg rsi
	280 Call Zombie.IsFlying, rcx, rdx
	281 Compare rax, 0
	282 JumpIfEqual {284}
	283 Add rsi, rsi, 0x2710
	284 Compare r15, 0
	285 JumpIfEqual {288}
	286 Compare rsi, r12
	287 JumpIfLessOrEqual {290}
	288 Move r12, rsi
	289 Move r15, rbx
	290 Move rax, [rdi+24]
	291 Add r14, r14, 1
	292 Move rdx, r14
	293 Compare rax, 0
	294 JumpIfEqual {322}
	295 Goto {65}
	296 Move xmm15, stack:0x60
	297 Move rax, r15
	298 Move xmm14, stack:0x70
	299 Move xmm13, stack:0x80
	300 Move xmm12, stack:0x90
	301 Move xmm11, stack:0xA0
	302 Move xmm10, stack:0xB0
	303 Move xmm9, stack:0xC0
	304 Move xmm8, stack:0xD0
	305 Move xmm7, stack:0xE0
	306 Move xmm6, stack:0xF0
	307 Move rsi, stack:0x138
	308 Move rbp, stack:0x130
	309 Move rbx, stack:0x148
	310 ShiftStack 256
	311 Move r15, stack:0x0
	312 ShiftStack 8
	313 Move r14, stack:0x0
	314 ShiftStack 8
	315 Move r13, stack:0x0
	316 ShiftStack 8
	317 Move r12, stack:0x0
	318 ShiftStack 8
	319 Move rdi, stack:0x0
	320 ShiftStack 8
	321 Return rax
	322 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
