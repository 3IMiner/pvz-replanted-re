# System.Void UpdateReanim()

- 类：`Plant`
- 汇编行数：737

## 反汇编

```asm

Disassembly:
	mov [rsp+18h],rbx
	push rdi
	sub rsp,0D0h
	cmp byte ptr [184EEB676h],0
	mov rbx,rcx
	jne near ptr 00000001806BB8BCh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C8D5F8h]
	call 00000001804FEB70h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	lea rcx,[184CAF9E8h]
	call 00000001804FEB70h
	lea rcx,[184CAF5C8h]
	call 00000001804FEB70h
	lea rcx,[184CAFD30h]
	call 00000001804FEB70h
	lea rcx,[184CAF918h]
	call 00000001804FEB70h
	lea rcx,[184CAFB90h]
	call 00000001804FEB70h
	lea rcx,[184CAF840h]
	call 00000001804FEB70h
	lea rcx,[184CAF698h]
	call 00000001804FEB70h
	lea rcx,[184CAF770h]
	call 00000001804FEB70h
	lea rcx,[184CAFC68h]
	call 00000001804FEB70h
	lea rcx,[184CAFE08h]
	call 00000001804FEB70h
	lea rcx,[184CAFAC0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB676h],1
	mov rcx,[184C2D478h]
	mov rdi,[rbx+140h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BB8D8h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832770h
	test al,al
	jne near ptr 00000001806BBEA4h
	mov [rsp+0E0h],rbp
	movaps [rsp+0C0h],xmm6
	movaps [rsp+0B0h],xmm7
	movaps [rsp+90h],xmm9
	movaps [rsp+80h],xmm10
	movaps [rsp+40h],xmm14
	xor edx,edx
	mov rcx,rbx
	call 00000001806BB0F0h
	mov eax,[rbx+34h]
	xor ebp,ebp
	mov r9d,[rbx+70h]
	mov r8,rbx
	mov rdx,[rbx+18h]
	mov rcx,[rbx+10h]
	movss xmm6,dword ptr [rbx+110h]
	mov [rsp+30h],rbp
	mov [rsp+28h],eax
	mov eax,[rbx+74h]
	mov [rsp+20h],eax
	call 00000001806B33C0h
	movss xmm14,dword ptr [183C33C4Ch]
	movaps xmm7,xmm0
	mov rcx,[184C2D478h]
	addss xmm7,xmm6
	mov rdi,[rbx+10h]
	movaps xmm6,xmm14
	movaps xmm9,xmm14
	cmp [rcx+0E4h],ebp
	jne short 00000001806BB988h
	call 00000001804FEEB0h
	movaps [rsp+0A0h],xmm8
	xor r8d,r8d
	xor edx,edx
	movaps [rsp+50h],xmm13
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je short 00000001806BB9DFh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BBEB5h
	xor edx,edx
	call 00000001807E3010h
	cmp eax,27h
	jne short 00000001806BB9DFh
	cmp dword ptr [rbx+70h],3
	je short 00000001806BB9D3h
	cmp dword ptr [rbx+70h],1
	je short 00000001806BB9D3h
	cmp dword ptr [rbx+70h],26h
	jne short 00000001806BB9DFh
	movss xmm6,dword ptr [183C33E14h]
	movaps xmm9,xmm6
	cmp dword ptr [rbx+70h],32h
	movss xmm8,dword ptr [183C33EBCh]
	movss xmm13,dword ptr [183C33DACh]
	jne short 00000001806BBA05h
	movss xmm6,dword ptr [183C33D94h]
	movaps xmm9,xmm6
	jmp short 00000001806BBA28h
	cmp dword ptr [rbx+70h],23h
	jne short 00000001806BBA12h
	addss xmm7,xmm13
	jmp short 00000001806BBA20h
	cmp dword ptr [rbx+70h],4
	jne short 00000001806BBA28h
	addss xmm7,dword ptr [183C33DB4h]
	movaps xmm9,xmm8
	movaps xmm6,xmm8
	cmp dword ptr [rbx+88h],9
	jne short 00000001806BBA80h
	mov rcx,[184C2AFC0h]
	mov edi,[rbx+0A0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806BBA4Bh
	call 00000001804FEEB0h
	movss xmm0,dword ptr [183C33C60h]
	xorps xmm3,xmm3
	movd xmm2,edi
	xor edx,edx
	mov [rsp+30h],rbp
	mov ecx,190h
	cvtdq2ps xmm2,xmm2
	mov dword ptr [rsp+28h],1
	movss dword ptr [rsp+20h],xmm0
	call 00000001806CC070h
	addss xmm7,xmm0
	cmp [rbx+124h],ebp
	jle short 00000001806BBAE6h
	mov rcx,[184C2AFC0h]
	mov edi,[rbx+124h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806BBAA2h
	call 00000001804FEEB0h
	movd xmm2,edi
	movaps xmm3,xmm14
	mov [rsp+30h],rbp
	xor edx,edx
	cvtdq2ps xmm2,xmm2
	mov dword ptr [rsp+28h],0Dh
	mov ecx,46h
	movss dword ptr [rsp+20h],xmm8
	call 00000001806CC070h
	movss xmm1,dword ptr [183C33DCCh]
	mulss xmm9,xmm0
	mulss xmm0,xmm1
	subss xmm1,xmm0
	addss xmm7,xmm1
	cmp dword ptr [rbx+70h],34h
	movss xmm8,dword ptr [183C33D6Ch]
	jne short 00000001806BBAFAh
	mulss xmm6,xmm8
	cmp dword ptr [rbx+130h],0FFFFFFFFh
	je near ptr 00000001806BBE22h
	mov rdi,[rbx+10h]
	test rdi,rdi
	je near ptr 00000001806BBEB5h
	mov rdi,[rdi+70h]
	test rdi,rdi
	je near ptr 00000001806BBEB5h
	mov r10,[rdi]
	movzx ecx,bp
	mov r9,[184C8D5F8h]
	movzx edx,word ptr [r10+12Eh]
	cmp bp,dx
	jae short 00000001806BBB56h
	mov r8,[r10+0B0h]
	movzx eax,cx
	add rax,rax
	cmp [r8+rax*8],r9
	je short 00000001806BBB9Fh
	inc cx
	cmp cx,dx
	jb short 00000001806BBB42h
	mov r8d,1Fh
	mov rdx,r9
	mov rcx,rdi
	call 00000001804FBC00h
	mov r8,[rax]
	mov rcx,rdi
	mov rdx,[rax+8]
	call r8
	test rax,rax
	je near ptr 00000001806BBEB5h
	mov rdi,[rax+0E8h]
	test rdi,rdi
	je near ptr 00000001806BBEB5h
	movsxd rax,dword ptr [rbx+130h]
	cmp eax,[rdi+18h]
	jae near ptr 00000001806BBEBBh
	jmp short 00000001806BBBBEh
	movzx ecx,cx
	add rcx,rcx
	mov eax,[r8+rcx*8+8]
	add eax,1Fh
	cdqe
	shl rax,4
	add rax,138h
	add rax,r10
	jmp short 00000001806BBB67h
	mov rdi,[rdi+rax*8+20h]
	test rdi,rdi
	je near ptr 00000001806BBEB5h
	cmp dword ptr [rdi+20h],1
	mov [rsp+0E8h],rsi
	movaps [rsp+70h],xmm11
	movaps [rsp+60h],xmm12
	jne short 00000001806BBBEBh
	mulss xmm6,xmm8
	cmp dword ptr [rdi+34h],1
	je short 00000001806BBC41h
	cmp dword ptr [rdi+34h],2
	je short 00000001806BBC17h
	movss xmm10,dword ptr [183C33DBCh]
	movaps xmm8,xmm13
	movss xmm11,dword ptr [183C33D58h]
	xorps xmm13,xmm13
	xorps xmm12,xmm12
	jmp short 00000001806BBC68h
	movss xmm8,dword ptr [183C33DBCh]
	movss xmm10,dword ptr [183C33DC4h]
	movaps xmm12,xmm8
	movss xmm11,dword ptr [183C33C40h]
	movss xmm14,dword ptr [183C33D58h]
	jmp short 00000001806BBC68h
	movss xmm8,dword ptr [183C33DBCh]
	movss xmm10,dword ptr [183C33DC4h]
	movaps xmm13,xmm8
	movss xmm11,dword ptr [183C33C40h]
	movaps xmm12,xmm10
	movaps xmm14,xmm11
	mov rcx,[184C2AFC0h]
	mov esi,[rbx+0A0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806BBC82h
	call 00000001804FEEB0h
	movd xmm2,esi
	movaps xmm3,xmm8
	mov [rsp+30h],rbp
	xor edx,edx
	cvtdq2ps xmm2,xmm2
	mov dword ptr [rsp+28h],1
	mov ecx,64h
	movss dword ptr [rsp+20h],xmm13
	call 00000001806CC070h
	movd xmm2,dword ptr [rbx+0A0h]
	movaps xmm3,xmm10
	mov [rsp+30h],rbp
	xor edx,edx
	cvtdq2ps xmm2,xmm2
	mov dword ptr [rsp+28h],1
	mov ecx,64h
	movss dword ptr [rsp+20h],xmm12
	call 00000001806CC070h
	movd xmm2,dword ptr [rbx+0A0h]
	movaps xmm3,xmm11
	mov [rsp+30h],rbp
	xor edx,edx
	cvtdq2ps xmm2,xmm2
	mov dword ptr [rsp+28h],1
	mov ecx,64h
	movss dword ptr [rsp+20h],xmm14
	call 00000001806CC070h
	mov rcx,[rbx+10h]
	movaps xmm12,[rsp+60h]
	movaps xmm11,[rsp+70h]
	mov rsi,[rsp+0E8h]
	mulss xmm6,xmm0
	mulss xmm9,xmm0
	test rcx,rcx
	je near ptr 00000001806BBEB5h
	mov rcx,[rcx+108h]
	test rcx,rcx
	je near ptr 00000001806BBEB5h
	xor r8d,r8d
	mov rdx,rdi
	call 00000001806E4660h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BBEB5h
	mov rcx,[rcx+108h]
	test rcx,rcx
	je near ptr 00000001806BBEB5h
	mov edx,[rbx+70h]
	xor r9d,r9d
	movaps xmm2,xmm9
	call 00000001806E0810h
	addss xmm7,xmm0
	cmp [rdi+30h],ebp
	je near ptr 00000001806BBE22h
	cmp [rdi+34h],ebp
	je near ptr 00000001806BBE22h
	mov eax,[rdi+30h]
	add eax,0FFFFFFFEh
	cmp eax,0Ah
	ja near ptr 00000001806BBE22h
	lea rdx,[180000000h]
	cdqe
	mov ecx,[rdx+rax*4+6BBEC4h]
	add rcx,rdx
	jmp rcx
	mov rdx,[184CAFD30h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAF918h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAF9E8h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAFAC0h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAF770h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAFB90h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAF5C8h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAFC68h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAF698h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAFE08h]
	jmp short 00000001806BBE17h
	mov rdx,[184CAF840h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806ABED0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BBEB5h
	xor r9d,r9d
	mov [rsp+20h],rbp
	movaps xmm2,xmm7
	xorps xmm1,xmm1
	call 00000001807C88F0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BBEB5h
	xor r9d,r9d
	mov [rsp+20h],rbp
	movaps xmm2,xmm9
	movaps xmm1,xmm6
	call 00000001807C81A0h
	movaps xmm13,[rsp+50h]
	movaps xmm8,[rsp+0A0h]
	movaps xmm9,[rsp+90h]
	movaps xmm10,[rsp+80h]
	movaps xmm7,[rsp+0B0h]
	movaps xmm6,[rsp+0C0h]
	mov rbp,[rsp+0E0h]
	movaps xmm14,[rsp+40h]
	mov rbx,[rsp+0F0h]
	add rsp,0D0h
	pop rdi
	ret
	call 00000001804FEE20h
	int 3
	call 00000001804FEE10h
	int 3
	nop dword ptr [rax]

ISIL:
	001 Move stack:0x18, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -208
	005 Compare [0x184EEB676], 0
	006 Move rbx, rcx
	007 JumpIfNotEqual {37}
	008 LoadAddress rcx, [0x184C2AFC0]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C8D5F8]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184C2D478]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 LoadAddress rcx, [0x184CAF9E8]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 LoadAddress rcx, [0x184CAF5C8]
	017 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	018 LoadAddress rcx, [0x184CAFD30]
	019 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	020 LoadAddress rcx, [0x184CAF918]
	021 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	022 LoadAddress rcx, [0x184CAFB90]
	023 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	024 LoadAddress rcx, [0x184CAF840]
	025 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	026 LoadAddress rcx, [0x184CAF698]
	027 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	028 LoadAddress rcx, [0x184CAF770]
	029 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	030 LoadAddress rcx, [0x184CAFC68]
	031 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	032 LoadAddress rcx, [0x184CAFE08]
	033 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	034 LoadAddress rcx, [0x184CAFAC0]
	035 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	036 Move [0x184EEB676], 1
	037 Move rcx, typeof(UnityEngine.Object)
	038 Move rdi, [rbx+320]
	039 Compare [rcx+228], 0
	040 JumpIfNotEqual {42}
	041 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	042 Move r8, 0
	043 Move rdx, 0
	044 Move rcx, rdi
	045 Call Object.op_Equality, rcx, rdx, r8
	046 Compare rax, 0
	047 JumpIfNotEqual {358}
	048 Move stack:0xE0, rbp
	049 Move stack:0xC0, xmm6
	050 Move stack:0xB0, xmm7
	051 Move stack:0x90, xmm9
	052 Move stack:0x80, xmm10
	053 Move stack:0x40, xmm14
	054 Move rdx, 0
	055 Move rcx, rbx
	056 Call Plant.UpdateReanimColor, rcx, rdx
	057 Move rax, [rbx+52]
	058 Move rbp, 0
	059 Move r9, [rbx+112]
	060 Move r8, rbx
	061 Move rdx, [rbx+24]
	062 Move rcx, [rbx+16]
	063 Move xmm6, [rbx+272]
	064 Move stack:0x30, rbp
	065 Move stack:0x28, rax
	066 Move rax, [rbx+116]
	067 Move stack:0x20, rax
	068 Call Plant.PlantDrawHeightOffset, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	069 Move xmm14, [0x183C33C4C]
	070 Move xmm7, xmm0
	071 Move rcx, typeof(UnityEngine.Object)
	072 Add xmm7, xmm7, xmm6
	073 Move rdi, [rbx+16]
	074 Move xmm6, xmm14
	075 Move xmm9, xmm14
	076 Compare [rcx+228], rbp
	077 JumpIfNotEqual {79}
	078 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	079 Move stack:0xA0, xmm8
	080 Move r8, 0
	081 Move rdx, 0
	082 Move stack:0x50, xmm13
	083 Move rcx, rdi
	084 Call Object.op_Inequality, rcx, rdx, r8
	085 Compare rax, 0
	086 JumpIfEqual {102}
	087 Move rcx, [rbx+16]
	088 Compare rcx, 0
	089 JumpIfEqual {363}
	090 Move rdx, 0
	091 Call GameplayActivity.get_GameMode, rcx, rdx
	092 Compare rax, 39
	093 JumpIfNotEqual {102}
	094 Compare [rbx+112], 3
	095 JumpIfEqual {100}
	096 Compare [rbx+112], 1
	097 JumpIfEqual {100}
	098 Compare [rbx+112], 38
	099 JumpIfNotEqual {102}
	100 Move xmm6, [0x183C33E14]
	101 Move xmm9, xmm6
	102 Compare [rbx+112], 50
	103 Move xmm8, [0x183C33EBC]
	104 Move xmm13, [0x183C33DAC]
	105 JumpIfNotEqual {109}
	106 Move xmm6, typeof(T)
	107 Move xmm9, xmm6
	108 Goto {118}
	109 Compare [rbx+112], 35
	110 JumpIfNotEqual {113}
	111 Add xmm7, xmm7, xmm13
	112 Goto {116}
	113 Compare [rbx+112], 4
	114 JumpIfNotEqual {118}
	115 Add xmm7, xmm7, [0x183C33DB4]
	116 Move xmm9, xmm8
	117 Move xmm6, xmm8
	118 Compare [rbx+136], 9
	119 JumpIfNotEqual {136}
	120 Move rcx, typeof(Reloaded.Gameplay.Common)
	121 Move rdi, [rbx+160]
	122 Compare [rcx+228], rbp
	123 JumpIfNotEqual {125}
	124 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	125 Move xmm0, [0x183C33C60]
	126 Move xmm3, 0
	127 Move xmm2, rdi
	128 Move rdx, 0
	129 Move stack:0x30, rbp
	130 Move rcx, 400
	131 Move xmm2, xmm2
	132 Move stack:0x28, 1
	133 Move stack:0x20, xmm0
	134 Call Common.TodAnimateCurveFloat, rcx, rdx, xmm2, xmm3, stack:0x0, stack:0x8, stack:0x10
	135 Add xmm7, xmm7, xmm0
	136 Compare [rbx+292], rbp
	137 JumpIfLessOrEqual {157}
	138 Move rcx, typeof(Reloaded.Gameplay.Common)
	139 Move rdi, [rbx+292]
	140 Compare [rcx+228], rbp
	141 JumpIfNotEqual {143}
	142 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	143 Move xmm2, rdi
	144 Move xmm3, xmm14
	145 Move stack:0x30, rbp
	146 Move rdx, 0
	147 Move xmm2, xmm2
	148 Move stack:0x28, 13
	149 Move rcx, 70
	150 Move stack:0x20, xmm8
	151 Call Common.TodAnimateCurveFloat, rcx, rdx, xmm2, xmm3, stack:0x0, stack:0x8, stack:0x10
	152 Move xmm1, [0x183C33DCC]
	153 Multiply xmm9, xmm9, xmm0
	154 Multiply xmm0, xmm0, xmm1
	155 Subtract xmm1, xmm1, xmm0
	156 Add xmm7, xmm7, xmm1
	157 Compare [rbx+112], 52
	158 Move xmm8, [0x183C33D6C]
	159 JumpIfNotEqual {161}
	160 Multiply xmm6, xmm6, xmm8
	161 Compare [rbx+304], 18446744073709551615
	162 JumpIfEqual {334}
	163 Move rdi, [rbx+16]
	164 Compare rdi, 0
	165 JumpIfEqual {363}
	166 Move rdi, [rdi+112]
	167 Compare rdi, 0
	168 JumpIfEqual {363}
	169 Move r10, [rdi]
	170 Move rcx, rbp
	171 Move r9, typeof(Reloaded.Services.IUserService)
	172 Move rdx, [r10+302]
	173 Compare rbp, rdx
	174 JumpIfGreaterOrEqual {183}
	175 Move r8, [r10+176]
	176 Move rax, rcx
	177 Add rax, rax, rax
	178 Compare [r8+rax*8], r9
	179 JumpIfEqual {200}
	180 Add rcx, rcx, 1
	181 Compare rcx, rdx
	182 JumpIfLess {176}
	183 Move r8, 31
	184 Move rdx, r9
	185 Move rcx, rdi
	186 Call 0x1804FBC00, rcx, rdx, r8, r9
	187 Move r8, [rax]
	188 Move rcx, rdi
	189 Move rdx, [rax+8]
	190 Call r8
	191 Compare rax, 0
	192 JumpIfEqual {363}
	193 Move rdi, [rax+232]
	194 Compare rdi, 0
	195 JumpIfEqual {363}
	196 Move rax, [rbx+304]
	197 Compare rax, [rdi+24]
	198 JumpIfGreaterOrEqual {365}
	199 Goto {209}
	200 Move rcx, rcx
	201 Add rcx, rcx, rcx
	202 Move rax, [r8+8+rcx*8]
	203 Add rax, rax, 31
	204 Move rax, rax
	205 ShiftLeft rax, 4
	206 Add rax, rax, 312
	207 Add rax, rax, r10
	208 Goto {187}
	209 Move rdi, [rdi+32+rax*8]
	210 Compare rdi, 0
	211 JumpIfEqual {363}
	212 Compare [rdi+32], 1
	213 Move stack:0xE8, rsi
	214 Move stack:0x70, xmm11
	215 Move stack:0x60, xmm12
	216 JumpIfNotEqual {218}
	217 Multiply xmm6, xmm6, xmm8
	218 Compare [rdi+52], 1
	219 JumpIfEqual {234}
	220 Compare [rdi+52], 2
	221 JumpIfEqual {228}
	222 Move xmm10, [0x183C33DBC]
	223 Move xmm8, xmm13
	224 Move xmm11, [0x183C33D58]
	225 Move xmm13, 0
	226 Move xmm12, 0
	227 Goto {240}
	228 Move xmm8, [0x183C33DBC]
	229 Move xmm10, [0x183C33DC4]
	230 Move xmm12, xmm8
	231 Move xmm11, [0x183C33C40]
	232 Move xmm14, [0x183C33D58]
	233 Goto {240}
	234 Move xmm8, [0x183C33DBC]
	235 Move xmm10, [0x183C33DC4]
	236 Move xmm13, xmm8
	237 Move xmm11, [0x183C33C40]
	238 Move xmm12, xmm10
	239 Move xmm14, xmm11
	240 Move rcx, typeof(Reloaded.Gameplay.Common)
	241 Move rsi, [rbx+160]
	242 Compare [rcx+228], rbp
	243 JumpIfNotEqual {245}
	244 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	245 Move xmm2, rsi
	246 Move xmm3, xmm8
	247 Move stack:0x30, rbp
	248 Move rdx, 0
	249 Move xmm2, xmm2
	250 Move stack:0x28, 1
	251 Move rcx, 100
	252 Move stack:0x20, xmm13
	253 Call Common.TodAnimateCurveFloat, rcx, rdx, xmm2, xmm3, stack:0x0, stack:0x8, stack:0x10
	254 Move xmm2, [rbx+160]
	255 Move xmm3, xmm10
	256 Move stack:0x30, rbp
	257 Move rdx, 0
	258 Move xmm2, xmm2
	259 Move stack:0x28, 1
	260 Move rcx, 100
	261 Move stack:0x20, xmm12
	262 Call Common.TodAnimateCurveFloat, rcx, rdx, xmm2, xmm3, stack:0x0, stack:0x8, stack:0x10
	263 Move xmm2, [rbx+160]
	264 Move xmm3, xmm11
	265 Move stack:0x30, rbp
	266 Move rdx, 0
	267 Move xmm2, xmm2
	268 Move stack:0x28, 1
	269 Move rcx, 100
	270 Move stack:0x20, xmm14
	271 Call Common.TodAnimateCurveFloat, rcx, rdx, xmm2, xmm3, stack:0x0, stack:0x8, stack:0x10
	272 Move rcx, [rbx+16]
	273 Move xmm12, stack:0x60
	274 Move xmm11, stack:0x70
	275 Move rsi, stack:0xE8
	276 Multiply xmm6, xmm6, xmm0
	277 Multiply xmm9, xmm9, xmm0
	278 Compare rcx, 0
	279 JumpIfEqual {363}
	280 Move rcx, [rcx+264]
	281 Compare rcx, 0
	282 JumpIfEqual {363}
	283 Move r8, 0
	284 Move rdx, rdi
	285 Call ZenGarden.ZenPlantOffsetX, rcx, rdx
	286 Move rcx, [rbx+16]
	287 Compare rcx, 0
	288 JumpIfEqual {363}
	289 Move rcx, [rcx+264]
	290 Compare rcx, 0
	291 JumpIfEqual {363}
	292 Move rdx, [rbx+112]
	293 Move r9, 0
	294 Move xmm2, xmm9
	295 Call ZenGarden.PlantPottedDrawHeightOffset, rcx, xmm1, r8
	296 Add xmm7, xmm7, xmm0
	297 Compare [rdi+48], rbp
	298 JumpIfEqual {334}
	299 Compare [rdi+52], rbp
	300 JumpIfEqual {334}
	301 Move rax, [rdi+48]
	302 Add rax, rax, 18446744073709551614
	303 Compare rax, 10
	304 JumpIfGreater {334}
	305 LoadAddress rdx, [0x180000000]
	306 Move rax, rax
	307 Move rcx, [rdx+0x6BBEC4+rax*4]
	308 Add rcx, rcx, rdx
	309 CallNoReturn rcx
	310 Move rdx, "Marigold_White"
	311 Goto {331}
	312 Move rdx, "Marigold_Magenta"
	313 Goto {331}
	314 Move rdx, "Marigold_Orange"
	315 Goto {331}
	316 Move rdx, "Marigold_Pink"
	317 Goto {331}
	318 Move rdx, "Marigold_LightBlue"
	319 Goto {331}
	320 Move rdx, "Marigold_Red"
	321 Goto {331}
	322 Move rdx, "Marigold_Blue"
	323 Goto {331}
	324 Move rdx, "Marigold_Violet"
	325 Goto {331}
	326 Move rdx, "Marigold_Lavender"
	327 Goto {331}
	328 Move rdx, "Marigold_Yellow"
	329 Goto {331}
	330 Move rdx, "Marigold_LightGreen"
	331 Move r8, 0
	332 Move rcx, rbx
	333 Call Plant.AttemptSetMarigoldColour, rcx, rdx
	334 Move rcx, [rbx+320]
	335 Compare rcx, 0
	336 JumpIfEqual {363}
	337 Move r9, 0
	338 Move stack:0x20, rbp
	339 Move xmm2, xmm7
	340 Move xmm1, 0
	341 Call 0x1807C88F0, rcx, xmm1, r8, r9
	342 Move rcx, [rbx+320]
	343 Compare rcx, 0
	344 JumpIfEqual {363}
	345 Move r9, 0
	346 Move stack:0x20, rbp
	347 Move xmm2, xmm9
	348 Move xmm1, xmm6
	349 Call ReloadedCharacterController.OverrideScale, rcx, xmm1, r8, r9
	350 Move xmm13, stack:0x50
	351 Move xmm8, stack:0xA0
	352 Move xmm9, stack:0x90
	353 Move xmm10, stack:0x80
	354 Move xmm7, stack:0xB0
	355 Move xmm6, stack:0xC0
	356 Move rbp, stack:0xE0
	357 Move xmm14, stack:0x40
	358 Move rbx, stack:0xF0
	359 ShiftStack 208
	360 Move rdi, stack:0x0
	361 ShiftStack 8
	362 Return 
	363 Call 0x1804FEE20, rcx, rdx, r8, r9
	364 Interrupt 
	365 Call 0x1804FEE10, rcx, rdx, r8, r9
	366 Interrupt 
	367 Nop
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
