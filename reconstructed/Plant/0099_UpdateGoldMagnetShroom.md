# System.Void UpdateGoldMagnetShroom()

- 类：`Plant`
- 汇编行数：731

## 反汇编

```asm

Disassembly:
	mov [rsp+10h],rbx
	mov [rsp+18h],rbp
	mov [rsp+20h],rsi
	push rdi
	push r12
	push r14
	sub rsp,0B0h
	cmp byte ptr [184EEB670h],0
	mov rbx,rcx
	movaps [rsp+70h],xmm9
	movaps [rsp+60h],xmm10
	movaps [rsp+50h],xmm11
	movaps [rsp+40h],xmm12
	jne short 00000001806B90B2h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C8D5F8h]
	call 00000001804FEB70h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	lea rcx,[184C93140h]
	call 00000001804FEB70h
	mov byte ptr [184EEB670h],1
	movss xmm12,dword ptr [183C33DBCh]
	xor bpl,bpl
	movss xmm9,dword ptr [183C33C34h]
	xor r12d,r12d
	movss xmm10,dword ptr [183C33C30h]
	mov esi,r12d
	movss xmm11,dword ptr [183C33E6Ch]
	mov r14d,20h
	mov [rsp+0D0h],r15
	movaps [rsp+0A0h],xmm6
	movaps [rsp+90h],xmm7
	movaps [rsp+80h],xmm8
	nop word ptr [rax+rax]
	mov rdi,[rbx+118h]
	test rdi,rdi
	je near ptr 00000001806B9668h
	cmp esi,[rdi+18h]
	jae near ptr 00000001806B9662h
	mov rdi,[r14+rdi]
	test rdi,rdi
	je near ptr 00000001806B9668h
	cmp [rdi+20h],r12d
	je near ptr 00000001806B9324h
	movss xmm6,dword ptr [rdi+18h]
	xor edx,edx
	addss xmm6,dword ptr [rbx+20h]
	movss xmm7,dword ptr [rdi+1Ch]
	addss xmm7,dword ptr [rbx+24h]
	subss xmm6,dword ptr [rdi+10h]
	subss xmm7,dword ptr [rdi+14h]
	movaps xmm0,xmm6
	unpcklps xmm0,xmm7
	movq rcx,xmm0
	call 00000001806AB080h
	movaps xmm8,xmm0
	comiss xmm12,xmm8
	ja short 00000001806B91DBh
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r12d
	jne short 00000001806B918Fh
	call 00000001804FEEB0h
	mov [rsp+30h],r12
	movaps xmm3,xmm10
	mov dword ptr [rsp+28h],1
	movaps xmm2,xmm8
	xorps xmm1,xmm1
	movss dword ptr [rsp+20h],xmm9
	movaps xmm0,xmm11
	call 00000001806CBFC0h
	mulss xmm6,xmm0
	mov bpl,1
	mulss xmm7,xmm0
	addss xmm6,dword ptr [rdi+10h]
	movss dword ptr [rdi+10h],xmm6
	addss xmm7,dword ptr [rdi+14h]
	movss dword ptr [rdi+14h],xmm7
	jmp near ptr 00000001806B9324h
	cmp dword ptr [rdi+20h],12h
	je short 00000001806B91FFh
	cmp dword ptr [rdi+20h],13h
	je short 00000001806B91F8h
	cmp dword ptr [rdi+20h],14h
	jne near ptr 00000001806B966Eh
	mov ecx,3
	jmp short 00000001806B9204h
	mov ecx,2
	jmp short 00000001806B9204h
	mov ecx,1
	xor edx,edx
	call 0000000180698250h
	mov r8,[rbx+10h]
	mov r15d,eax
	test r8,r8
	je near ptr 00000001806B9668h
	mov r8,[r8+70h]
	test r8,r8
	je near ptr 00000001806B9668h
	mov rdx,[184C8D5F8h]
	mov ecx,46h
	mov r9d,eax
	call 0000000180002040h
	mov rdx,[rbx+18h]
	test rdx,rdx
	je near ptr 00000001806B9668h
	add [rdx+300h],r15d
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806B9668h
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B9668h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,1Fh
	call 0000000180002040h
	mov [rdi+20h],r12d
	mov rax,[rbx+150h]
	test rax,rax
	je near ptr 00000001806B9668h
	cmp esi,[rax+18h]
	jae near ptr 00000001806B9662h
	mov rcx,[184C2D478h]
	mov rdi,[rax+r14]
	cmp [rcx+0E4h],r12d
	jne short 00000001806B92B7h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je short 00000001806B92F5h
	mov rax,[rbx+150h]
	test rax,rax
	je near ptr 00000001806B9668h
	cmp esi,[rax+18h]
	jae near ptr 00000001806B9662h
	mov rcx,[rax+r14]
	test rcx,rcx
	je near ptr 00000001806B9668h
	xor edx,edx
	call 00000001807B45E0h
	mov rcx,[rbx+150h]
	test rcx,rcx
	je near ptr 00000001806B9668h
	cmp esi,[rcx+18h]
	jae near ptr 00000001806B9662h
	mov [rcx+r14],r12
	xor edx,edx
	movsxd rax,esi
	lea rcx,[rcx+rax*8]
	add rcx,20h
	call 00000001804FDEA0h
	inc esi
	add r14,8
	cmp esi,5
	jl near ptr 00000001806B9110h
	cmp dword ptr [rbx+88h],1Bh
	je near ptr 00000001806B9646h
	cmp dword ptr [rbx+88h],1Ah
	je near ptr 00000001806B9568h
	cmp [184EEB67Bh],r12b
	jne short 00000001806B9381h
	lea rcx,[184C7F5F0h]
	call 00000001804FEB70h
	lea rcx,[184C7F6C8h]
	call 00000001804FEB70h
	lea rcx,[184CA0500h]
	call 00000001804FEB70h
	mov byte ptr [184EEB67Bh],1
	mov rax,[rbx+18h]
	mov edi,r12d
	mov edx,r12d
	test rax,rax
	je near ptr 00000001806B9668h
	movss xmm6,dword ptr [183C33C40h]
	nop dword ptr [rax]
	mov rcx,[rax+78h]
	test rcx,rcx
	je near ptr 00000001806B9668h
	cmp edx,[rcx+28h]
	jge near ptr 00000001806B9496h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806B9668h
	mov rcx,[rax+78h]
	test rcx,rcx
	je near ptr 00000001806B9668h
	mov r8,[184C7F6C8h]
	mov edx,edi
	call 0000000182449330h
	test rax,rax
	je near ptr 00000001806B9668h
	cmp dword ptr [rax+70h],11h
	jne short 00000001806B940Ch
	cmp dword ptr [rax+88h],5
	je near ptr 00000001806B9480h
	cmp dword ptr [rax+88h],6
	je short 00000001806B9480h
	cmp dword ptr [rax+88h],7
	je short 00000001806B9480h
	cmp [rax+3Ch],r12b
	jne short 00000001806B9480h
	cmp dword ptr [rax+128h],2
	je short 00000001806B9480h
	cmp [rax+135h],r12b
	jne short 00000001806B9480h
	cmp dword ptr [rax+70h],2Dh
	jne short 00000001806B9480h
	cmp dword ptr [rax+88h],1Ah
	jne short 00000001806B9480h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B9668h
	mov rdx,[184CA0500h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C7EF0h
	test al,al
	je near ptr 00000001806B9516h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B9668h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	comiss xmm6,xmm0
	ja near ptr 00000001806B9516h
	mov rax,[rbx+18h]
	inc edi
	mov edx,edi
	test rax,rax
	je near ptr 00000001806B9668h
	jmp near ptr 00000001806B93A0h
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r12d
	jne short 00000001806B94ABh
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,32h
	call 00000001806CBE80h
	test eax,eax
	jne short 00000001806B9516h
	xor edx,edx
	mov rcx,rbx
	call 00000001806AF170h
	test rax,rax
	je short 00000001806B9516h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B9668h
	xor edx,edx
	call 00000001806709E0h
	movss xmm0,dword ptr [183C33DB4h]
	mov r9d,14h
	mov dword ptr [rbx+88h],1Ah
	mov r8d,3
	mov rdx,[184C93140h]
	mov rcx,rbx
	mov [rsp+28h],r12
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	movaps xmm8,[rsp+80h]
	lea r11,[rsp+0B0h]
	mov rbx,[r11+28h]
	mov rbp,[r11+30h]
	mov rsi,[r11+38h]
	movaps xmm9,[r11-40h]
	movaps xmm10,[r11-50h]
	movaps xmm11,[r11-60h]
	movaps xmm12,[r11-70h]
	movaps xmm7,[rsp+90h]
	movaps xmm6,[rsp+0A0h]
	mov r15,[rsp+0D0h]
	mov rsp,r11
	pop r14
	pop r12
	pop rdi
	ret
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B9668h
	movss xmm1,dword ptr [183C33C3Ch]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8910h
	test al,al
	je short 00000001806B95CAh
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B9668h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B9668h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,2Ah
	call 0000000180002040h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B1C60h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B9668h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806B9637h
	test bpl,bpl
	jne short 00000001806B9637h
	movss xmm1,dword ptr [183C33FA4h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B4C50h
	mov dword ptr [rbx+88h],1Bh
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r12d
	jne short 00000001806B961Fh
	call 00000001804FEEB0h
	xor r8d,r8d
	mov edx,12Ch
	mov ecx,0C8h
	call 00000001806CBDF0h
	mov [rbx+0A0h],eax
	xor edx,edx
	mov rcx,rbx
	call 00000001806AE500h
	jmp near ptr 00000001806B9516h
	cmp [rbx+0A0h],r12d
	jne near ptr 00000001806B9516h
	mov dword ptr [rbx+88h],1
	jmp near ptr 00000001806B9516h
	call 00000001804FEE10h
	int 3
	call 00000001804FEE20h
	int 3
	lea rcx,[184C52578h]
	call 00000001804FEB90h
	mov rcx,rax
	call 00000001804FEDD0h
	lea rcx,[184C9A1F8h]
	mov rbx,rax
	call 00000001804FEB90h
	mov rdx,rax
	xor r8d,r8d
	mov rcx,rbx
	call 0000000182C223D0h
	lea rcx,[184C43F68h]
	call 00000001804FEB90h
	mov rdx,rax
	mov rcx,rbx
	call 00000001804FEDE0h

ISIL:
	001 Move stack:0x10, rbx
	002 Move stack:0x18, rbp
	003 Move stack:0x20, rsi
	004 ShiftStack -8
	005 Move stack:0x0, rdi
	006 ShiftStack -8
	007 Move stack:0x0, r12
	008 ShiftStack -8
	009 Move stack:0x0, r14
	010 ShiftStack -176
	011 Compare [0x184EEB670], 0
	012 Move rbx, rcx
	013 Move stack:0x70, xmm9
	014 Move stack:0x60, xmm10
	015 Move stack:0x50, xmm11
	016 Move stack:0x40, xmm12
	017 JumpIfNotEqual {29}
	018 LoadAddress rcx, [0x184C2AFC0]
	019 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	020 LoadAddress rcx, [0x184C75168]
	021 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	022 LoadAddress rcx, [0x184C8D5F8]
	023 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	024 LoadAddress rcx, [0x184C2D478]
	025 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	026 LoadAddress rcx, [0x184C93140]
	027 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	028 Move [0x184EEB670], 1
	029 Move xmm12, [0x183C33DBC]
	030 Move rbp, 0
	031 Move xmm9, [0x183C33C34]
	032 Move r12, 0
	033 Move xmm10, [0x183C33C30]
	034 Move rsi, r12
	035 Move xmm11, [0x183C33E6C]
	036 Move r14, 32
	037 Move stack:0xD0, r15
	038 Move stack:0xA0, xmm6
	039 Move stack:0x90, xmm7
	040 Move stack:0x80, xmm8
	041 Nop 
	042 Move rdi, [rbx+280]
	043 Compare rdi, 0
	044 JumpIfEqual {351}
	045 Compare rsi, [rdi+24]
	046 JumpIfGreaterOrEqual {349}
	047 Move rdi, [r14+rdi]
	048 Compare rdi, 0
	049 JumpIfEqual {351}
	050 Compare [rdi+32], r12
	051 JumpIfEqual {166}
	052 Move xmm6, [rdi+24]
	053 Move rdx, 0
	054 Add xmm6, xmm6, [rbx+32]
	055 Move xmm7, [rdi+28]
	056 Add xmm7, xmm7, [rbx+36]
	057 Subtract xmm6, xmm6, [rdi+16]
	058 Subtract xmm7, xmm7, [rdi+20]
	059 Move xmm0, xmm6
	060 Move XMM_TEMP.S[0], xmm0.S[0]
	061 Move XMM_TEMP.S[1], xmm7.S[0]
	062 Move XMM_TEMP.S[2], xmm0.S[1]
	063 Move XMM_TEMP.S[3], xmm7.S[1]
	064 Move xmm0, XMM_TEMP
	065 Move rcx, xmm0
	066 Call 0x1806AB080, rcx, rdx, r8, r9
	067 Move xmm8, xmm0
	068 Compare xmm12, xmm8
	069 JumpIfGreater {90}
	070 Move rcx, typeof(Reloaded.Gameplay.Common)
	071 Compare [rcx+228], r12
	072 JumpIfNotEqual {74}
	073 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	074 Move stack:0x30, r12
	075 Move xmm3, xmm10
	076 Move stack:0x28, 1
	077 Move xmm2, xmm8
	078 Move xmm1, 0
	079 Move stack:0x20, xmm9
	080 Move xmm0, xmm11
	081 Call Common.TodAnimateCurveFloatTime, xmm0, xmm1, xmm2, xmm3, stack:0x0, stack:0x8, stack:0x10
	082 Multiply xmm6, xmm6, xmm0
	083 Move rbp, 1
	084 Multiply xmm7, xmm7, xmm0
	085 Add xmm6, xmm6, [rdi+16]
	086 Move [rdi+16], xmm6
	087 Add xmm7, xmm7, [rdi+20]
	088 Move [rdi+20], xmm7
	089 Goto {166}
	090 Compare [rdi+32], 18
	091 JumpIfEqual {100}
	092 Compare [rdi+32], 19
	093 JumpIfEqual {98}
	094 Compare [rdi+32], 20
	095 JumpIfNotEqual {353}
	096 Move rcx, 3
	097 Goto {101}
	098 Move rcx, 2
	099 Goto {101}
	100 Move rcx, 1
	101 Move rdx, 0
	102 Call Coin.GetCoinValue, rcx, rdx
	103 Move r8, [rbx+16]
	104 Move r15, rax
	105 Compare r8, 0
	106 JumpIfEqual {351}
	107 Move r8, [r8+112]
	108 Compare r8, 0
	109 JumpIfEqual {351}
	110 Move rdx, typeof(Reloaded.Services.IUserService)
	111 Move rcx, 70
	112 Move r9, rax
	113 Call 0x180002040, rcx, rdx, r8, r9
	114 Move rdx, [rbx+24]
	115 Compare rdx, 0
	116 JumpIfEqual {351}
	117 Add [rdx+768], [rdx+768], r15
	118 Move r8, [rbx+16]
	119 Compare r8, 0
	120 JumpIfEqual {351}
	121 Move r8, [r8+88]
	122 Compare r8, 0
	123 JumpIfEqual {351}
	124 Move rdx, typeof(Reloaded.Services.IAudioService)
	125 Move rcx, 6
	126 Move r9, 31
	127 Call 0x180002040, rcx, rdx, r8, r9
	128 Move [rdi+32], r12
	129 Move rax, [rbx+336]
	130 Compare rax, 0
	131 JumpIfEqual {351}
	132 Compare rsi, [rax+24]
	133 JumpIfGreaterOrEqual {349}
	134 Move rcx, typeof(UnityEngine.Object)
	135 Move rdi, [rax+r14]
	136 Compare [rcx+228], r12
	137 JumpIfNotEqual {139}
	138 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	139 Move r8, 0
	140 Move rdx, 0
	141 Move rcx, rdi
	142 Call Object.op_Inequality, rcx, rdx, r8
	143 Compare rax, 0
	144 JumpIfEqual {155}
	145 Move rax, [rbx+336]
	146 Compare rax, 0
	147 JumpIfEqual {351}
	148 Compare rsi, [rax+24]
	149 JumpIfGreaterOrEqual {349}
	150 Move rcx, [rax+r14]
	151 Compare rcx, 0
	152 JumpIfEqual {351}
	153 Move rdx, 0
	154 Call MagnetItemController.Die, rcx, rdx
	155 Move rcx, [rbx+336]
	156 Compare rcx, 0
	157 JumpIfEqual {351}
	158 Compare rsi, [rcx+24]
	159 JumpIfGreaterOrEqual {349}
	160 Move [rcx+r14], r12
	161 Move rdx, 0
	162 Move rax, rsi
	163 LoadAddress rcx, [rcx+rax*8]
	164 Add rcx, rcx, 32
	165 Call 0x1804FDEA0, rcx, rdx, r8, r9
	166 Add rsi, rsi, 1
	167 Add r14, r14, 8
	168 Compare rsi, 5
	169 JumpIfLess {42}
	170 Compare [rbx+136], 27
	171 JumpIfEqual {345}
	172 Compare [rbx+136], 26
	173 JumpIfEqual {295}
	174 Compare [0x184EEB67B], r12
	175 JumpIfNotEqual {183}
	176 LoadAddress rcx, [0x184C7F5F0]
	177 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	178 LoadAddress rcx, [0x184C7F6C8]
	179 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	180 LoadAddress rcx, [0x184CA0500]
	181 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	182 Move [0x184EEB67B], 1
	183 Move rax, [rbx+24]
	184 Move rdi, r12
	185 Move rdx, r12
	186 Compare rax, 0
	187 JumpIfEqual {351}
	188 Move xmm6, [0x183C33C40]
	189 Nop 
	190 Move rcx, [rax+120]
	191 Compare rcx, 0
	192 JumpIfEqual {351}
	193 Compare rdx, [rcx+40]
	194 JumpIfGreaterOrEqual {247}
	195 Move rax, [rbx+24]
	196 Compare rax, 0
	197 JumpIfEqual {351}
	198 Move rcx, [rax+120]
	199 Compare rcx, 0
	200 JumpIfEqual {351}
	201 Move r8, [0x184C7F6C8]
	202 Move rdx, rdi
	203 Call 0x182449330, rcx, rdx
	204 Compare rax, 0
	205 JumpIfEqual {351}
	206 Compare [rax+112], 17
	207 JumpIfNotEqual {214}
	208 Compare [rax+136], 5
	209 JumpIfEqual {241}
	210 Compare [rax+136], 6
	211 JumpIfEqual {241}
	212 Compare [rax+136], 7
	213 JumpIfEqual {241}
	214 Compare [rax+60], r12
	215 JumpIfNotEqual {241}
	216 Compare [rax+296], 2
	217 JumpIfEqual {241}
	218 Compare [rax+309], r12
	219 JumpIfNotEqual {241}
	220 Compare [rax+112], 45
	221 JumpIfNotEqual {241}
	222 Compare [rax+136], 26
	223 JumpIfNotEqual {241}
	224 Move rcx, [rbx+320]
	225 Compare rcx, 0
	226 JumpIfEqual {351}
	227 Move rdx, "attract"
	228 Move r9, 0
	229 Move r8, 0
	230 Call ReloadedCharacterController.IsCurrentAnimationOnTrack, rcx, rdx, r8
	231 Compare rax, 0
	232 JumpIfEqual {275}
	233 Move rcx, [rbx+320]
	234 Compare rcx, 0
	235 JumpIfEqual {351}
	236 Move r8, 0
	237 Move rdx, 0
	238 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	239 Compare xmm6, xmm0
	240 JumpIfGreater {275}
	241 Move rax, [rbx+24]
	242 Add rdi, rdi, 1
	243 Move rdx, rdi
	244 Compare rax, 0
	245 JumpIfEqual {351}
	246 Goto {190}
	247 Move rcx, typeof(Reloaded.Gameplay.Common)
	248 Compare [rcx+228], r12
	249 JumpIfNotEqual {251}
	250 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	251 Move rdx, 0
	252 Move rcx, 50
	253 Call Common.Rand, rcx, rdx
	254 Compare rax, 0
	255 JumpIfNotEqual {275}
	256 Move rdx, 0
	257 Move rcx, rbx
	258 Call Plant.FindGoldMagnetTarget, rcx, rdx
	259 Compare rax, 0
	260 JumpIfEqual {275}
	261 Move rcx, [rbx+24]
	262 Compare rcx, 0
	263 JumpIfEqual {351}
	264 Move rdx, 0
	265 Call Board.ShowCoinBank, rcx, rdx
	266 Move xmm0, [0x183C33DB4]
	267 Move r9, 20
	268 Move [rbx+136], 26
	269 Move r8, 3
	270 Move rdx, "anim_attract"
	271 Move rcx, rbx
	272 Move stack:0x28, r12
	273 Move stack:0x20, xmm0
	274 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	275 Move xmm8, stack:0x80
	276 LoadAddress r11, stack:0xB0
	277 Move rbx, [r11+40]
	278 Move rbp, [r11+48]
	279 Move rsi, [r11+56]
	280 Move xmm9, [r11-64]
	281 Move xmm10, [r11-80]
	282 Move xmm11, [r11-96]
	283 Move xmm12, [r11-112]
	284 Move xmm7, stack:0x90
	285 Move xmm6, stack:0xA0
	286 Move r15, stack:0xD0
	287 Move rsp, r11
	288 Move r14, stack:0x0
	289 ShiftStack 8
	290 Move r12, stack:0x0
	291 ShiftStack 8
	292 Move rdi, stack:0x0
	293 ShiftStack 8
	294 Return 
	295 Move rcx, [rbx+320]
	296 Compare rcx, 0
	297 JumpIfEqual {351}
	298 Move xmm1, [0x183C33C3C]
	299 Move r9, 0
	300 Move r8, 0
	301 Call ReloadedCharacterController.ShouldTriggerTimedEvent, rcx, rdx, r8
	302 Compare rax, 0
	303 JumpIfEqual {317}
	304 Move rax, [rbx+16]
	305 Compare rax, 0
	306 JumpIfEqual {351}
	307 Move r8, [rax+88]
	308 Compare r8, 0
	309 JumpIfEqual {351}
	310 Move rdx, typeof(Reloaded.Services.IAudioService)
	311 Move rcx, 6
	312 Move r9, 42
	313 Call 0x180002040, rcx, rdx, r8, r9
	314 Move rdx, 0
	315 Move rcx, rbx
	316 Call Plant.GoldMagnetFindTargets, rcx, rdx
	317 Move rcx, [rbx+320]
	318 Compare rcx, 0
	319 JumpIfEqual {351}
	320 Move r8, 0
	321 Move rdx, 0
	322 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	323 Compare rax, 0
	324 JumpIfLessOrEqual {341}
	325 Compare rbp, 0
	326 JumpIfNotEqual {341}
	327 Move xmm1, [0x183C33FA4]
	328 Move r8, 0
	329 Move rcx, rbx
	330 Call Plant.PlayIdleAnim, rcx, rdx
	331 Move [rbx+136], 27
	332 Move rcx, typeof(Reloaded.Gameplay.Common)
	333 Compare [rcx+228], r12
	334 JumpIfNotEqual {336}
	335 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	336 Move r8, 0
	337 Move rdx, 300
	338 Move rcx, 200
	339 Call Common.RandRangeInt, rcx, rdx, r8
	340 Move [rbx+160], rax
	341 Move rdx, 0
	342 Move rcx, rbx
	343 Call Plant.DrawMagnetItems, rcx, rdx
	344 Goto {275}
	345 Compare [rbx+160], r12
	346 JumpIfNotEqual {275}
	347 Move [rbx+136], 1
	348 Goto {275}
	349 Call 0x1804FEE10, rcx, rdx, r8, r9
	350 Interrupt 
	351 Call 0x1804FEE20, rcx, rdx, r8, r9
	352 Interrupt 
	353 LoadAddress rcx, [0x184C52578]
	354 Call 0x1804FEB90, rcx, rdx, r8, r9
	355 Move rcx, rax
	356 Call "il2cpp_codegen_object_new", rcx, rdx, r8, r9
	357 LoadAddress rcx, [0x184C9A1F8]
	358 Move rbx, rax
	359 Call 0x1804FEB90, rcx, rdx, r8, r9
	360 Move rdx, rax
	361 Move r8, 0
	362 Move rcx, rbx
	363 Call Exception..ctor, rcx, rdx
	364 LoadAddress rcx, [0x184C43F68]
	365 Call 0x1804FEB90, rcx, rdx, r8, r9
	366 Move rdx, rax
	367 Move rcx, rbx
	368 Call 0x1804FEDE0, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
